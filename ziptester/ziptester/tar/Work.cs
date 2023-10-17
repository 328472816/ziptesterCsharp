using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using ziptester.tool;

namespace ziptester.tar
{
    class Work
    {
        private int filetype;
        public int FileType { get { return filetype; } set { filetype = value; } }
        private string tarpath;
        public string TarPath { get { return tarpath; } set { tarpath = value; } }
        private string keypath;
        public string KeyPath { get { return keypath; } set { keypath = value; } }

        public event EventHandler NowWorkProgressEvent;
        public event EventHandler WorkResultEvent;
        public event EventHandler WorkGetKeyEvent;

        public void worktask()
        {
            try
            {
                Console.WriteLine("压缩包:" + TarPath);
                Console.WriteLine("密码本:" + KeyPath);
                switch (FileType)
                {
                    case 0:
                            zipwork();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("test fail.");
                WorkResultEvent.Invoke(e.ToString(), new EventArgs());
                return;// true;
            }
            finally
            {

            }
            Debug.WriteLine("File transfer is succesful");
            Console.WriteLine("done");
            WorkResultEvent.Invoke("OK", new EventArgs());
            return;// true;
        }
        #region zip
        private bool zipwork()
        {
            //获取密码
            string[] lines = File.ReadAllLines(KeyPath);
            int process = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                Debug.WriteLine("testing" + lines[i]);
                Console.WriteLine("testing" + lines[i]);

                //测试密码
                try
                {
                    if (Ziphelper.TestUnZip(TarPath, lines[i]) == true)
                    {
                        //拿到密码
                        WorkGetKeyEvent.Invoke(lines[i], new EventArgs());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("test fail:"+lines[i]);
                    //WorkResultEvent.Invoke(e.ToString(), new EventArgs());
                }
                finally
                {

                }
                process = (i+1) * 100 / lines.Length;
                NowWorkProgressEvent.Invoke(process, new EventArgs());
            }
                return true;
        }
        #endregion
    }


}
