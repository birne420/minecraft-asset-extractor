using Minecraft_Asset_Extractor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_AssetExtraction {
    public partial class Main : Form {
        private string _mcPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
        private List<string> _jarPaths = new List<string>();
        private List<string> _indexPaths = new List<string>();
        private bool _jarExtraction = false;
        private bool _objExtraction = false;
        private string _customFilter = string.Empty;
        private string _selectedJarPath = string.Empty;
        private string _selectedIndexPath = string.Empty;
        private bool _jarUseCustomFilter = false;
        private bool _extractionIsRunning = false;
        private string _outputPath = string.Empty;
        private string _outputPathGenerated = string.Empty;
        private string _loggingName = "general.log";
        private System.Threading.Thread _extractionThread;

        private void _msg(string what, string title) {
            MessageBox.Show(this, what, title);
        }
        private void _log(string what, string message) {
            string logString = DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss::fff]") + " " + what.ToUpper() + ": " + message + "\n";
            System.IO.File.AppendAllText(_loggingName, logString);
            RichTextBoxLog.AppendText(logString);

            RichTextBoxLog.SelectionStart = RichTextBoxLog.Text.Length;
            RichTextBoxLog.ScrollToCaret();

            if (RichTextBoxLog.Text.Length > 40960) {
                RichTextBoxLog.Clear();
            }
        }
        private void _logLn() {
            RichTextBoxLog.AppendText("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            RichTextBoxLog.SelectionStart = RichTextBoxLog.Text.Length;
            RichTextBoxLog.ScrollToCaret();
        }

        private void _error(string message, Exception ex) {
            _log("error", ex.ToString());
            MessageBox.Show(this, message + ": " + ex.Message, "Error!");
        }

        public Main() {
            InitializeComponent();

            _logLn();
            _log("main", "Interface initialized.");
        }
        private void _initJars() {
            ComboBoxJar.Items.Add("<none>");
            ComboBoxJar.SelectedIndex = 0;

            _log("init", "Looking for jar files in '" + _mcPath + "\\versions" + "'...");

            try {
                foreach (string _directoryPath in System.IO.Directory.GetDirectories(_mcPath + "\\versions")) {
                    string _requestedVersion = System.IO.Path.GetFileName(_directoryPath);
                    string _jarPath = _directoryPath + "\\" + _requestedVersion + ".jar";
                    if (System.IO.File.Exists(_jarPath)) {
                        _log("info", "Jar file found '" + _jarPath + "'.");

                        _jarPaths.Add(_jarPath);
                        ComboBoxJar.Items.Add(System.IO.Path.GetFileName(_jarPath));
                    }
                }
            } catch(Exception ex) {
                _error("Failed to load version data", ex);
            }
        }
        private void _initIndexes() {
            ComboBoxHashMap.Items.Add("<none>");
            ComboBoxHashMap.SelectedIndex = 0;

            _log("init", "Looking for hashmap indexes in '" + _mcPath + "\\assets\\indexes" + "'...");

            try {
                foreach (string _filePath in System.IO.Directory.GetFiles(_mcPath + "\\assets\\indexes")) {
                    _log("info", "Index file found '" + _filePath + "'.");

                    _indexPaths.Add(_filePath);
                    ComboBoxHashMap.Items.Add(System.IO.Path.GetFileName(_filePath));
                }
            } catch (Exception ex) {
                _error("Failed to load index data", ex);
            }
        }

        private void Main_Load(object sender, EventArgs e) {
            _initJars();
            _initIndexes();

            RadioButtonJarAssets.Checked = true;

            TextBoxOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\minecraft_assets";

            _log("main", "Done!");
            _logLn();
        }

        private void ComboBoxJar_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboBoxJar.SelectedIndex == 0) {
                GroupBoxJarFilter.Enabled = false;
                _jarExtraction = false;
                _selectedJarPath = string.Empty;
                _log("config", "Jar extraction disabled.");
            } else {
                GroupBoxJarFilter.Enabled = true;
                _jarExtraction = true;
                _selectedJarPath = _jarPaths.ElementAt(ComboBoxJar.SelectedIndex - 1);
                _log("config", "Jar extraction set to '" + System.IO.Path.GetFileNameWithoutExtension(ComboBoxJar.SelectedItem.ToString()) + "'.");
            }

            if (_jarExtraction == false && _objExtraction == false) {
                ButtonExtract.Enabled = false;
            } else {
                ButtonExtract.Enabled = true;
            }
        }

        private void RadioButtonJarAssets_CheckedChanged(object sender, EventArgs e) {
            if (RadioButtonJarAssets.Checked) {
                CheckBoxJarFilterPNG.Enabled = false;
                CheckBoxJarFilterPNG.Checked = false;
                CheckBoxJarFilterJSON.Enabled = false;
                CheckBoxJarFilterJSON.Checked = false;
                CheckBoxJarFilterOGG.Enabled = false;
                CheckBoxJarFilterOGG.Checked = false;
                CheckBoxJarFilterLANG.Enabled = false;
                CheckBoxJarFilterLANG.Checked = false;
                CheckBoxJarFilterMCMETA.Enabled = false;
                CheckBoxJarFilterMCMETA.Checked = false;
                _jarUseCustomFilter = false;
                _log("config", "Jar extraction parameter set: 'AssetDirectory'.");
            } else {
                CheckBoxJarFilterPNG.Enabled = true;
                CheckBoxJarFilterJSON.Enabled = true;
                CheckBoxJarFilterOGG.Enabled = true;
                CheckBoxJarFilterLANG.Enabled = true;
                CheckBoxJarFilterMCMETA.Enabled = true;
                _jarUseCustomFilter = true;
                _log("config", "Jar extraction parameter set: 'CustomFilter'.");
            }
        }

        private void ComboBoxHashMap_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboBoxHashMap.SelectedIndex == 0) {
                _objExtraction = false;
                _selectedIndexPath = string.Empty;
                _log("config", "Object unmapping disabled.");
            } else {
                _objExtraction = true;
                _selectedIndexPath = _indexPaths.ElementAt(ComboBoxHashMap.SelectedIndex - 1);
                _log("config", "Object unmapping set to '" + System.IO.Path.GetFileNameWithoutExtension(ComboBoxHashMap.SelectedItem.ToString()) + "'.");
            }

            if (_jarExtraction == false && _objExtraction == false) {
                ButtonExtract.Enabled = false;
            } else {
                ButtonExtract.Enabled = true;
            }
        }
        private void _updateCustomFilter() {
            string filterString = "";
            if (CheckBoxJarFilterPNG.Checked) {
                filterString += ".png;";
            }
            if (CheckBoxJarFilterJSON.Checked) {
                filterString += ".json;";
            }
            if (CheckBoxJarFilterOGG.Checked) {
                filterString += ".ogg;";
            }
            if (CheckBoxJarFilterLANG.Checked) {
                filterString += ".lang;";
            }
            if (CheckBoxJarFilterMCMETA.Checked) {
                filterString += ".mcmeta;";
            }
            if (filterString.Length > 0) {
                _customFilter = filterString.Substring(0, filterString.Length - 1);
                _log("config", "Custom Filter set to '" + _customFilter + "'.");
            } else {
                _customFilter = string.Empty;
                _log("config", "Custom Filter disabled, set to all files.");
            }
        }
        private void CheckBoxJarFilterPNG_CheckedChanged(object sender, EventArgs e) {
            _log("config", "Filter toggled: 'PNG'.");
            _updateCustomFilter();
        }
        private void CheckBoxJarFilterJSON_CheckedChanged(object sender, EventArgs e) {
            _log("config", "Filter toggled: 'JSON'.");
            _updateCustomFilter();
        }
        private void CheckBoxJarFilterOGG_CheckedChanged(object sender, EventArgs e) {
            _log("config", "Filter toggled: 'OGG'.");
            _updateCustomFilter();
        }
        private void CheckBoxJarFilterLANG_CheckedChanged(object sender, EventArgs e) {
            _log("config", "Filter toggled: 'LANG'.");
            _updateCustomFilter();
        }
        private void CheckBoxJarFilterMCMETA_CheckedChanged(object sender, EventArgs e) {
            _log("config", "Filter toggled: 'MCMETA'.");
            _updateCustomFilter();
        }

        //DELEGATE FUNCTIONS
        private void _enableComponents(bool state) {
            GroupBoxJar.Enabled = state;
            GroupBoxJarFilter.Enabled = state;
            GroupBoxObjects.Enabled = state;
            TextBoxOutput.Enabled = state;
            ButtonBrowse.Enabled = state;
            if (state) {
                ButtonExtract.Text = "Start asset extraction";
            } else {
                ButtonExtract.Text = "Abort";
            }
        }
        private static string convertJsonStringToResourcePath(string jsonString) {
            string tmp = jsonString.Split(new char[]
            {
                ':'
            })[0];
            return tmp.Substring(1, tmp.Length - 2).Replace("/", "\\");
        }
        private delegate void _logDelegate(string what, string message);
        private delegate void _logLnDelegate();
        private delegate void _errorDelegate(string message, Exception ex);
        private delegate void _enableComponentsDelegate(bool state);
        private delegate void _msgDelegate(string what, string title);
        private void _extractAssets() {
            _logDelegate _delLog = _log;
            _logLnDelegate _delLogLn = _logLn;
            _errorDelegate _delError = _error;
            _enableComponentsDelegate _delEnableComponents = _enableComponents;
            _msgDelegate _delMsg = _msg;

            this.Invoke(_delEnableComponents, false);

            this.Invoke(_delLogLn);
            this.Invoke(_delLog, "main", "Asset extraction initiated.");

            try {
                if (_jarExtraction == true) {
                    this.Invoke(_delLog, "extract-jar", "Accessing jar file '" + _selectedJarPath + "'.");
                    System.IO.Compression.ZipArchive _jarData = System.IO.Compression.ZipFile.OpenRead(_selectedJarPath);

                    this.Invoke(_delLog, "extract-jar", "Extracting assets...");
                    if (_jarUseCustomFilter) {
                        string[] _filterArr = _customFilter.Split(';');
                        foreach (System.IO.Compression.ZipArchiveEntry _cEntry in _jarData.Entries) {
                            for (int i = 0; i < _filterArr.Length; i++) {
                                if (_cEntry.FullName.EndsWith(_filterArr[i])) {
                                    string outPath = _outputPathGenerated + "\\filtered_jar\\" + _cEntry.FullName.Replace('/', '\\');
                                    System.IO.Directory.CreateDirectory(System.IO.Directory.GetParent(outPath).FullName);
                                    _cEntry.ExtractToFile(outPath);
                                    this.Invoke(_delLog, "extract-jar", "Extracted resource to '" + outPath + "'.");
                                }
                            }
                        }
                    } else {
                        foreach (System.IO.Compression.ZipArchiveEntry _cEntry in _jarData.Entries) {
                            if (_cEntry.FullName.StartsWith("assets/")) {
                                string outPath = _outputPathGenerated + "\\jar_assets\\" + _cEntry.FullName.Replace('/', '\\');
                                System.IO.Directory.CreateDirectory(System.IO.Directory.GetParent(outPath).FullName);
                                _cEntry.ExtractToFile(outPath);
                                this.Invoke(_delLog, "extract-jar", "Extracted resource to '" + outPath + "'.");
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                this.Invoke(_delError, "Jar extraction failed", ex);
            }

            try {
                if (_objExtraction == true) {
                    this.Invoke(_delLog, "unmap-objects", "Parsing JSON script '" + _selectedIndexPath + "'.");
                    JObject _jsonData = JObject.Parse(System.IO.File.ReadAllText(_selectedIndexPath));
                    JToken _jsonTkn = _jsonData.GetValue("objects");
                    int _assetCount = _jsonTkn.Children().Count();
                    for (int i = 0; i < _assetCount; i++) {
                        JToken _currentAssetJson = _jsonTkn.Children().ElementAt(i);
                        string _resourceName = convertJsonStringToResourcePath(_currentAssetJson.ToString());
                        AssetEntry _currentAssetEntry = JsonConvert.DeserializeObject<AssetEntry>(_currentAssetJson.First().ToString());
                        string _resourceParentName = _currentAssetEntry.hash.Substring(0, 2);
                        string _copyIn = string.Concat(new string[] { _mcPath, "\\assets\\objects\\", _resourceParentName, "\\", _currentAssetEntry.hash });
                        string _copyOut = _outputPathGenerated + "\\unmapped_assets\\" + _resourceName;
                        string _copyOutParentDirectory = System.IO.Directory.GetParent(_copyOut).FullName;
                        System.IO.Directory.CreateDirectory(_copyOutParentDirectory);
                        System.IO.File.Copy(_copyIn, _copyOut);
                        this.Invoke(_delLog, "unmap-objects", "Copied '" + _copyIn + "' to '" + _copyOut + "'.");
                    }
                }
            } catch (Exception ex) {
                this.Invoke(_delError, "Unmapping failed", ex);
            }


            this.Invoke(_delLog, "main", "Asset extraction finished.");
            this.Invoke(_delLog, "main", "Done!");

            this.Invoke(_delMsg, "Thread is done.", "Processed!");

            _loggingName = "general.log";

            _extractionIsRunning = false;

            try {
                Process.Start(_outputPathGenerated);
            } catch(Exception) { }

            this.Invoke(_delEnableComponents, true);
        }
        private void ButtonExtract_Click(object sender, EventArgs e) {
            if (_extractionIsRunning) {
                _extractionThread.Abort();
                _enableComponents(true);
                _extractionIsRunning = false;
            } else {
                _outputPathGenerated = _outputPath + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss");
                _loggingName = _outputPathGenerated + ".log";
                System.IO.Directory.CreateDirectory(System.IO.Directory.GetParent(_loggingName).FullName);

                _extractionThread = new System.Threading.Thread(new System.Threading.ThreadStart(_extractAssets));
                _extractionThread.Start();
                _extractionIsRunning = true;
            }
            
        }
        private void ButtonBrowse_Click(object sender, EventArgs e) {
            FolderBrowserDialog _dialog = new FolderBrowserDialog();
            _dialog.SelectedPath = TextBoxOutput.Text;
            _dialog.Description = "Choose output folder";
            if (_dialog.ShowDialog() == DialogResult.OK) {
                TextBoxOutput.Text = _dialog.SelectedPath;
            } 
        }
        private void TextBoxOutput_TextChanged(object sender, EventArgs e) {
            _outputPath = System.IO.Path.GetFullPath(TextBoxOutput.Text);
            _log("config", "Set output location to '" + _outputPath + "'.");
        }
    }
}
