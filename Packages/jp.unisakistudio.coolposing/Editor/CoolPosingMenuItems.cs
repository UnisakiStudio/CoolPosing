/*
 * CoolPosingEditor
 * カッコいいポーズツールの簡易設定用ツール
 * 
 * Copyright(c) 2024 UniSakiStudio
 */

using UnityEditor;
using UnityEngine;
using VRC.SDK3.Avatars.Components;
using jp.unisakistudio.posingsystemeditor;
using System.IO;

#if UNITY_EDITOR_WIN
using Microsoft.Win32;
#endif

namespace jp.unisakistudio.coolposingeditor
{
    public static class CoolPosingMenuItems
    {
        private const string REGKEY = @"SOFTWARE\UnisakiStudio";
        private const string COOLPOSING_APPKEY = "coolposing";
        private const string LICENSE_VALUE = "licensed";

        [MenuItem("GameObject/ゆにさきスタジオ/カッコいいポーズツール追加", false, 20)]
        static public void AddPrefab01() { PosingSystemMenuItems.AddPrefab("カッコいいポーズ"); }
        [MenuItem("GameObject/ゆにさきスタジオ/カッコいいポーズツール追加(8bit・足の高さなし)", false, 21)]
        static public void AddPrefab10() { PosingSystemMenuItems.AddPrefab("カッコいいポーズ(8bit・足の高さなし)"); }

        [MenuItem("GameObject/ゆにさきスタジオ/カッコいいポーズツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/カッコいいポーズツール追加(8bit・足の高さなし)", true)]
        private static bool Validate()
        {
            if (!Selection.activeGameObject)
            {
                return false;
            }
            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }
        
        // ========================================
        // ライセンス関連
        // ========================================
        
        /// <summary>
        /// Mac/Linux用の設定ファイルパス
        /// </summary>
        private static string GetLicenseFilePath()
        {
#if UNITY_EDITOR_OSX
            string appSupport = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appSupport, "UnisakiStudio", $"{COOLPOSING_APPKEY}.lic");
#elif UNITY_EDITOR_LINUX
            string homeDir = System.Environment.GetEnvironmentVariable("HOME");
            return Path.Combine(homeDir, ".local", "share", "UnisakiStudio", $"{COOLPOSING_APPKEY}.lic");
#else
            return null;
#endif
        }
        
        /// <summary>
        /// ライセンスがインストールされているかチェック
        /// </summary>
        private static bool IsLicensed()
        {
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY);
                if (regKey != null)
                {
                    var value = (string)regKey.GetValue(COOLPOSING_APPKEY);
                    regKey.Close();
                    return value == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#elif UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath();
                if (File.Exists(licenseFilePath))
                {
                    string fileContent = File.ReadAllText(licenseFilePath);
                    return fileContent == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#else
            return false;
#endif
        }
        
        /// <summary>
        /// ライセンスを削除
        /// </summary>
        [MenuItem("Tools/ゆにさきスタジオ/カッコいいポーズツールライセンス削除", false, 204)]
        public static void UninstallLicense()
        {
            if (!IsLicensed())
            {
                EditorUtility.DisplayDialog(
                    "ライセンスの削除",
                    "カッコいいポーズツールのライセンスはインストールされていません。",
                    "OK"
                );
                return;
            }
            
            bool shouldUninstall = EditorUtility.DisplayDialog(
                "ライセンス削除",
                "カッコいいポーズツールのライセンスを削除しますか？\n\n" +
                "削除すると、ツールの機能が制限されます。\n" +
                "再度ライセンスを有効化するには、ライセンスインストーラーを再インポートする必要があります。",
                "削除",
                "キャンセル"
            );
            
            if (!shouldUninstall)
            {
                return;
            }
            
            string resultMessage = "";
            
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY, true);
                if (regKey != null)
                {
                    // CoolPosingライセンスを削除
                    try
                    {
                        regKey.DeleteValue(COOLPOSING_APPKEY, false);
                    }
                    catch (System.Exception) { }
                    
                    // レジストリキーが空になった場合は削除
                    if (regKey.ValueCount == 0 && regKey.SubKeyCount == 0)
                    {
                        regKey.Close();
                        Registry.CurrentUser.DeleteSubKey(REGKEY, false);
                        resultMessage = "カッコいいポーズツールのライセンスを削除しました。";
                    }
                    else
                    {
                        regKey.Close();
                        resultMessage = "カッコいいポーズツールのライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[CoolPosing] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[CoolPosing] {resultMessage}");
            }
#endif
            
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath();
                
                // ライセンスファイルを削除
                if (File.Exists(licenseFilePath))
                {
                    File.Delete(licenseFilePath);
                    
                    // ディレクトリが空になった場合は削除
                    string directoryPath = Path.GetDirectoryName(licenseFilePath);
                    if (Directory.Exists(directoryPath) && 
                        Directory.GetFiles(directoryPath).Length == 0 && 
                        Directory.GetDirectories(directoryPath).Length == 0)
                    {
                        Directory.Delete(directoryPath);
                        resultMessage = "カッコいいポーズツールのライセンスを削除しました。";
                    }
                    else
                    {
                        resultMessage = "カッコいいポーズツールのライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[CoolPosing] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[CoolPosing] {resultMessage}");
            }
#endif
            
            EditorUtility.DisplayDialog(
                "ライセンス削除",
                resultMessage,
                "OK"
            );
        }
    }
}
