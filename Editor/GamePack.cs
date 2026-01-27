/// -------------------------------------------------------------------------------
/// Copyright (C) 2025, Hainan Yuanyou Information Technology Co., Ltd. Guangzhou Branch
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// -------------------------------------------------------------------------------

using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using ICSharpCode.SharpZipLib.Zip;

namespace GameFramework.Editor.Launcher
{
    /// <summary>
    /// 业务包安装类
    /// </summary>
    internal static class GamePack
    {
        private static float sTime = 0;

        private static ZipHelper.ZipCallback ZipCB = null;
        private static ZipHelper.UnzipCallback UnZipCB = null;

        [MenuItem("Nova/Test/Zip")]
        public static void OnClickZip()
        {
            ZipCB = new ZipResult();

            sTime = Time.realtimeSinceStartup;
            string[] paths = {
                Path.Combine(Application.dataPath, "Sources/Agen"),
                Path.Combine(Application.dataPath, "Sources/Game"),
                Path.Combine(Application.dataPath, "Sources/GameHotfix")
            };
            ZipHelper.Zip(paths, Path.Combine(Application.dataPath, "StreamingAssets/UI.zip"), null, ZipCB);
        }

        [MenuItem("Nova/Test/UnZip")]
        public static void OnClickUnzip()
        {
            Debug.Log("Start UnZip");
            UnZipCB = new UnZipResult();

            sTime = Time.realtimeSinceStartup;

            ZipHelper.UnzipFile(Path.Combine(Application.dataPath, "StreamingAssets/UI.zip"),
                                Path.Combine(Application.dataPath, "StreamingAssets/"), null, UnZipCB);
        }

        private class ZipResult : ZipHelper.ZipCallback
        {
            public bool OnPreZip(ZipEntry _entry)
            {
                if (_entry.IsFile)
                {
                    //Debug.Log(_entry.Name);
                    if (GetFileSuffix(_entry.Name) == "meta")
                        return false;
                }

                return true;
            }

            public void OnPostZip(ZipEntry _entry)
            {

            }

            public void OnFinished(bool _result)
            {
                Debug.Log("Zip Finished : " + (Time.realtimeSinceStartup - sTime));

                AssetDatabase.Refresh();
            }

            public string GetFileSuffix(string path)
            {
                int _index = path.LastIndexOf(".", StringComparison.Ordinal) + 1;
                return path.Substring(_index, path.Length - _index);
            }
        }

        private class UnZipResult : ZipHelper.UnzipCallback
        {
            public bool OnPreUnzip(ZipEntry _entry)
            {
                return true;
            }

            public void OnPostUnzip(ZipEntry _entry)
            {
                //Debug.Log(_entry.Name);
            }

            public void OnFinished(bool _result)
            {
                Debug.Log("UnZip Finished : " + (Time.realtimeSinceStartup - sTime));

                AssetDatabase.Refresh();
            }
        }
    }
}
