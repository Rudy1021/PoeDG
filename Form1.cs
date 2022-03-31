using gma.System.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace PoeDG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listcollection.Clear();

        }

        List<String> listcollection = new List<string> { };
        private void Form1_Load(object sender, EventArgs e)
        {
            PreOrSuf.SelectedIndex = 0;
            Tier.SelectedIndex = 0;
            readTXT();
        }
        /*Hook*/
        /*Hook*/
        /*座標
        蛻變 55, 281
        改造 103 275
        增幅 222 331
        富豪 432 280
        重鑄 429 514
        裝備 328 469
        空點 604 705
        混沌 535 275
        座標*/
        /*模擬滑鼠*/
        /*左鍵*/

        public void LeftClicktrans()
        {
            Cursor.Position = new Point(55, 281);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickalt()
        {
            Cursor.Position = new Point(103, 275);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickaug()
        {
            Cursor.Position = new Point(222, 331);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickregal()
        {
            Cursor.Position = new Point(432, 280);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickscour()
        {
            Cursor.Position = new Point(312, 431);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickammour()
        {
            Cursor.Position = new Point(328, 469);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        public void LeftClickspace()
        {
            Cursor.Position = new Point(604, 705);
            Thread.Sleep(20);
            MouseClick2.LeftClick();
        }
        /*左鍵*/
        /*右鍵*/
        public void RightClicktrans()
        {
            MouseClicks.MouseRightClickEvent(55, 281, 0);
        }
        public void RightClickalt()
        {
            Cursor.Position = new Point(103, 275);
            Thread.Sleep(20);
            MouseClick2.RightClick();
            //MouseClicks.MouseRightClickEvent(103, 275, 0);
        }
        public void RightClickchaos()
        {
            Cursor.Position = new Point(535, 275);
            Thread.Sleep(20);
            MouseClick2.RightClick();
            //MouseClicks.MouseRightClickEvent(103, 275, 0);
        }
        public void RightClickaug()
        {
            Cursor.Position = new Point(222, 331);
            Thread.Sleep(20);
            MouseClick2.RightClick();
        }
        public void RightClickregal()
        {
            Cursor.Position = new Point(432, 280);
            Thread.Sleep(20);
            MouseClick2.RightClick();
        }
        public void RightClickscour()
        {
            Cursor.Position = new Point(312, 431);
            Thread.Sleep(20);
        }
        public void RightClickammour()
        {
            Cursor.Position = new Point(328, 469);
            Thread.Sleep(20);
            MouseClick2.RightClick();
        }
        public void RightClickspace()
        {
            Cursor.Position = new Point(604, 705);
            Thread.Sleep(20);
            MouseClick2.RightClick();
        }
        /*右鍵*/
        /*移動*/
        public void MoveTotrans()
        {
            Cursor.Position = new Point(55, 281);
        }
        public void MoveToalt()
        {
            Cursor.Position = new Point(103, 275);
        }
        public void MoveToaug()
        {
            Cursor.Position = new Point(222, 331);
        }
        public void MoveToregal()
        {
            Cursor.Position = new Point(432, 280);
        }
        public void MoveToscour()
        {
            Cursor.Position = new Point(312, 431);
        }
        public void MoveToammour()
        {
            Cursor.Position = new Point(328, 469);
        }
        public void MoveTospace()
        {
            Cursor.Position = new Point(604, 705);
        }
        /*移動*/
        /*模擬滑鼠*/
        private void readTXT()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\w8674\\source\\repos\\PoeDG\\PoeDG\\ItemAffix.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    listcollection.Add(line);
                    //write the line to console window
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            AffixListBox.Items.Clear();
            foreach (string str in listcollection)
            {
                AffixListBox.Items.Add(str);
            }
        }

        private void AffixList_Click(object sender, EventArgs e)
        {
            this.AffixListBox.Visible = true;
            this.newOrClearBtn.Text = "清除";
        }
        private void AffixList_Leave(object sender, EventArgs e)
        {
            this.AffixListBox.Visible = false;
        }

        private void AffixListBox_Click(object sender, EventArgs e)
        {
            this.AffixList.Text = AffixListBox.GetItemText(AffixListBox.SelectedItem);
            this.AffixListBox.Visible = false;
        }

        private void AffixList_TextChanged(object sender, EventArgs e)
        {
            if (AffixList.Text != "")
            {
                for (int i = AffixListBox.Items.Count - 1; i >= 0; i--)
                {
                    if (AffixListBox.Items[i].ToString().Contains(AffixList.Text) == false)
                    {
                        AffixListBox.Items.RemoveAt(i);
                    }
                }
                if (AffixListBox.SelectedItems.Count == 1)
                {
                    AffixListBox.Focus();
                }
            }
            else
            {
                AffixListBox.Items.Clear();
                foreach (string str in listcollection)
                {
                    AffixListBox.Items.Add(str);
                }
            }
        }

        private void newOrClearBtn_Click(object sender, EventArgs e)
        {
            if (this.newOrClearBtn.Text == "清除")
            {
                this.AffixList.Text = "";
                AffixListBox.Visible = false;
            }
            else if (this.newOrClearBtn.Text == "新增")
            {
                this.AffixList.Text = "";
                this.AffixList.Enabled = true;
                this.newOrClearBtn.Text = "清除";
                this.newToListViewBtn.Text = "新增";
                this.AffixList.Focus();
            }
        }

        private void newToListViewBtn_Click(object sender, EventArgs e)
        {
            if (this.newToListViewBtn.Text == "新增")
            {
                string affixstr = "";
                if (this.mustHaveCheck.Checked == true)
                {
                    affixstr = "★";
                }
                affixstr += this.AffixList.Text;
                if (Tier.SelectedItem.ToString() != "")
                {
                    affixstr += "@" + Tier.SelectedItem.ToString();
                }
                /*
                if (maxNum.Value >= minNum.Value && maxNum.Value != 0)
                {
                    affixstr += "@" + minNum.Value + "~" + maxNum.Value;
                }
                else if (minNum.Value == 0 && maxNum.Value == 0)
                {

                }
                else if (Int32.Parse(maxNum.Text) <= Int32.Parse(minNum.Text))
                {
                    MessageBox.Show("最大最小值錯誤!");
                    return;
                }
                */
                this.AffixListView.Items.Add(affixstr);
                this.AffixList.Text = "";
                /*
                this.minNum.Value = 0;
                this.maxNum.Value = 0;
                this.mustHaveCheck.Checked = false;
                */
                Tier.SelectedIndex = 0;
            }
            else
            {
                this.AffixList.Enabled = true;
                ListViewItem item = AffixListView.SelectedItems[0];
                string affixstr = "";
                if (this.mustHaveCheck.Checked == true)
                {
                    affixstr = "★";
                }
                affixstr += this.AffixList.Text;
                if (Tier.SelectedItem.ToString() != "")
                {
                    affixstr += "@" + Tier.SelectedItem.ToString();
                }
                /*
                if (maxNum.Value >= minNum.Value && maxNum.Value != 0)
                {
                    affixstr += "@" + minNum.Value + "~" + maxNum.Value;
                }
                else if (minNum.Value == 0 && maxNum.Value == 0)
                {

                }
                else if (Int32.Parse(maxNum.Text) <= Int32.Parse(minNum.Text))
                {
                    MessageBox.Show("最大最小值錯誤!");
                    return;
                }
                */
                item.SubItems[0].Text = affixstr;
                this.AffixList.Text = "";
                /*
                this.minNum.Value = 0;
                this.maxNum.Value = 0;
                this.mustHaveCheck.Checked = false;
                */
                Tier.SelectedIndex = 0;
            }

        }

        private void AffixListView_Click(object sender, EventArgs e)
        {
            this.AffixListBox.Visible = false;
            if (this.AffixListView.SelectedItems.Count >= 1)
            {
                ListViewItem item = this.AffixListView.SelectedItems[0];
                if (item.Text.Split('@').Length > 1)
                {
                    string[] word = item.Text.Split('@');
                    for (int k = 0; k <= Tier.Items.Count - 1; k++)
                    {
                        if (Tier.Items[k].ToString() == word[1])
                        {
                            Tier.SelectedIndex = k;
                            break;
                        }
                    }
                    /*
                    string[] minMax = word[1].Split('~');
                    this.minNum.Value = Convert.ToDecimal(minMax[0]);
                    this.maxNum.Value = Convert.ToDecimal(minMax[1]);
                    if (word[0].Substring(0, 1) == "★")
                    {
                        this.AffixList.Text = word[0].Substring(1);
                        this.mustHaveCheck.Checked = true;
                    }
                    else
                    {
                        this.AffixList.Text = word[0];
                    }
                    */
                    this.AffixList.Text = word[0];
                }
                else
                {
                    this.AffixList.Text = item.Text;
                    /*
                    if (item.Text.Substring(0, 1) == "★")
                    {
                        this.AffixList.Text = item.Text.Substring(1);
                        this.mustHaveCheck.Checked = true;
                    }
                    else
                    {
                        this.AffixList.Text = item.Text;
                    }
                    */
                }

                newOrClearBtn.Text = "新增";
                newToListViewBtn.Text = "修改";
                this.AffixList.Enabled = false;
            }
        }

        private void WindowTop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.WindowTop.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void StartWork_Click(object sender, EventArgs e)
        {
            if (this.AffixListView.Items.Count < 1)
            {
                MessageBox.Show("尚未輸入字串!");
                return;
            }
            WorkLog.Text = "";
            WorkLog.Text = "開始詞綴勞工!\r\n";
            int successAffix = Decimal.ToInt32(AffixNum.Value);
            int workNum = Decimal.ToInt32(workCount.Value);
            int Ms = Decimal.ToInt32(TimeMs.Value);
            string[] AffixWantArray = new string[AffixListView.Items.Count];
            //Thread.Sleep(Decimal.ToInt32(TimeMs.Value));
            //Thread.Sleep(2);
            for (int i = 0; i < AffixListView.Items.Count; i++)
            {
                AffixWantArray[i] = AffixListView.Items[i].Text;
            }
            LeftClickspace();
            Thread.Sleep(2);
            if (chaos.Checked == true)
            {
                UseChao(AffixWantArray, successAffix, workNum, Ms);
            }
            else
            {
                UseAug(AffixWantArray, successAffix, workNum, Ms);
            }

        }

        private void AffixListView_DoubleClick(object sender, EventArgs e)
        {
            AffixListView.SelectedItems[0].Remove();
            AffixList.Text = "";
            AffixList.Enabled = true;
            newToListViewBtn.Text = "新增";
            newOrClearBtn.Text = "清除";
            minNum.Value = 0;
            maxNum.Value = 0;
        }
        private void UseAug(string[] Affix, int successAffix, int workNum, int Ms)
        {
            for (int i = 1; i < workNum + 1; i++)
            {
                //string[] PreorSuf = [];
                Thread.Sleep(Ms);
                MoveToammour();
                Thread.Sleep(100);
                SendKeys.Send("%^{C}");
                Thread.Sleep(Ms);
                string a = Clipboard.GetText(TextDataFormat.Text);
                string[] AffixArray = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (AffixArray[AffixArray.Length - 1].Contains("塑界者") ||
                    AffixArray[AffixArray.Length - 1].Contains("異界尊師") ||
                    AffixArray[AffixArray.Length - 1].Contains("聖戰士") ||
                    AffixArray[AffixArray.Length - 1].Contains("救贖者") ||
                    AffixArray[AffixArray.Length - 1].Contains("狩獵者") ||
                    AffixArray[AffixArray.Length - 1].Contains("總督軍") ||
                    AffixArray[AffixArray.Length - 1].Contains("劫盜成員") ||
                    AffixArray[AffixArray.Length - 1].Contains("尊師之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("塑者之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("天賦樹"))
                {
                    Array.Resize(ref AffixArray, AffixArray.Length - 2);
                }
                int b = Array.FindLastIndex(AffixArray,
                element => element.StartsWith("--------",
                StringComparison.Ordinal));
                string Rarity = AffixArray[1].Substring(5);
                if (Rarity == "普通")
                {
                    RightClicktrans();
                    Thread.Sleep(Ms);
                    LeftClickammour();
                }
                else if (Rarity == "魔法")
                {
                    for (int j = 0; j < Affix.Length; j++)
                    {
                        bool check = Regex.IsMatch(Affix[j], @"@");
                        if (check == true)
                        {

                            string[] vs = Affix[j].Split('@');
                            string[] vm = vs[0].Split(' ');
                            string tier = vs[1].Substring(vs[1].Length - 1);
                            for (int k = b + 1; k < AffixArray.Length; k++)
                            {
                                string[] vw = AffixArray[k].Split('\n');
                                if (vw[0].Split(' ')[1].Substring(0, 1) == PreOrSuf.SelectedItem.ToString() &&
                                    k == b + 1 &&
                                    AffixArray.Length - (b + 1) == 1 &&
                                    augCheck.Checked == true)
                                {
                                    WorkLog.AppendText("【 X 】" + vw[1] + "\r\n");
                                    WorkLog.AppendText("使用增幅石\r\n");
                                    RightClickaug();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                    i--;
                                }
                                else
                                {
                                    if (vw[vw.Length - 1].Contains("無法使用"))
                                    {
                                        Array.Resize(ref vw, 1);

                                    }
                                    if (vw[1].Split(' ').Length != Affix[j].Split(' ').Length)
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                            RightClickalt();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                    else
                                    {
                                        if (Affix[j].Split(' ').Length == 1)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;
                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (Affix[j].Split(' ').Length == 2)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1].Split(' ')[1])
                                            {
                                                if (int.Parse(vw[0].Split(')')[0].Substring(vw[0].Split(')')[0].Length - 1)) <= int.Parse(tier))
                                                {
                                                    WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("成功!恭喜!");
                                                    return;
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }

                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (vm[0] == vw[vw.Length - 1].Split(' ')[0])
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1].Split(' ')[vw[vw.Length - 1].Split(' ').Length - 1])
                                            {
                                                if (int.Parse(vw[0].Split(')')[0].Substring(vw[0].Split(')')[0].Length - 1)) <= int.Parse(tier))
                                                {
                                                    WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("成功!恭喜!");
                                                    return;
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k == AffixArray.Length - 1)
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                RightClickalt();
                                                Thread.Sleep(Ms);
                                                LeftClickammour();
                                            }
                                            else
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            }
                                        }
                                    }
                                }
                            }


                        }
                        else // check == false
                        {
                            string[] vm = Affix[j].Split(' ');
                            for (int k = b + 1; k < AffixArray.Length; k++)
                            {

                                string[] vw = AffixArray[k].Split('\n');
                                if (vw[0].Split(' ')[1].Substring(0, 1) == PreOrSuf.SelectedItem.ToString() &&
                                    k == b + 1 &&
                                    AffixArray.Length - (b + 1) == 1 &&
                                    augCheck.Checked == true)
                                {
                                    WorkLog.AppendText("【 X 】" + vw[1] + "\r\n");
                                    WorkLog.AppendText("使用增幅石\r\n");
                                    RightClickaug();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                    i--;
                                }
                                else
                                {
                                    vw = vw[1].Split(' ');
                                    if(vw[vw.Length - 1].Contains("無法使用"))
                                    {
                                        Array.Resize(ref vw, 1);

                                    }
                                    if (vw.Length != Affix[j].Split(' ').Length)
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                            RightClickalt();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                    else
                                    {
                                        if (Affix[j].Split(' ').Length == 1)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;
                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (Affix[j].Split(' ').Length == 2)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;

                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (vm[0] == vw[0])
                                        {
                                            if (vm[Affix[j].Split(' ').Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;
                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k == AffixArray.Length - 1)
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("第" + i + "次點《改造石》\r\n");
                                                RightClickalt();
                                                Thread.Sleep(Ms);
                                                LeftClickammour();
                                            }
                                            else
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                else if (Rarity == "稀有")
                {
                    RightClickscour();
                    Thread.Sleep(Ms);
                    LeftClickammour();
                }

            }
        }
        private void UseChao(string[] Affix, int successAffix, int workNum, int Ms)
        {
            for (int i = 1; i < workNum + 1; i++)
            {
                //string[] PreorSuf = [];
                Thread.Sleep(Ms);
                MoveToammour();
                Thread.Sleep(100);
                SendKeys.Send("%^{C}");
                Thread.Sleep(Ms);
                string a = Clipboard.GetText(TextDataFormat.Text);
                string[] AffixArray = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (AffixArray[AffixArray.Length - 1].Contains("塑界者") ||
                    AffixArray[AffixArray.Length - 1].Contains("異界尊師") ||
                    AffixArray[AffixArray.Length - 1].Contains("聖戰士") ||
                    AffixArray[AffixArray.Length - 1].Contains("救贖者") ||
                    AffixArray[AffixArray.Length - 1].Contains("狩獵者") ||
                    AffixArray[AffixArray.Length - 1].Contains("總督軍") ||
                    AffixArray[AffixArray.Length - 1].Contains("劫盜成員") ||
                    AffixArray[AffixArray.Length - 1].Contains("尊師之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("塑者之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("之物") ||
                    AffixArray[AffixArray.Length - 1].Contains("天賦樹"))
                {
                    Array.Resize(ref AffixArray, AffixArray.Length - 2);
                }
                int b = Array.FindLastIndex(AffixArray,
                element => element.StartsWith("--------",
                StringComparison.Ordinal));
                for (int j = 0; j < Affix.Length; j++)
                {
                    bool check = Regex.IsMatch(Affix[j], @"@");
                    if (check == true)
                    {

                        string[] vs = Affix[j].Split('@');
                        string[] vm = vs[0].Split(' ');
                        string tier = vs[1].Substring(vs[1].Length - 1);
                        for (int k = b + 1; k < AffixArray.Length; k++)
                        {
                            string[] vw = AffixArray[k].Split('\n');
                            if (vw[1].Split(' ').Length != Affix[j].Split(' ').Length)
                            {
                                if (k == AffixArray.Length - 1)
                                {
                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                    WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                    RightClickchaos();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                }
                                else
                                {
                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                }
                            }
                            else
                            {
                                if (Affix[j].Split(' ').Length == 2)
                                {
                                    if (vm[vm.Length - 1] == vw[vw.Length - 1].Split(' ')[1])
                                    {
                                        if (int.Parse(vw[0].Split(')')[0].Substring(vw[0].Split(')')[0].Length - 1)) <= int.Parse(tier))
                                        {
                                            WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("成功!恭喜!");
                                            return;
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }

                                    }
                                    else
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                }
                                else if (vm[0] == vw[vw.Length - 1].Split(' ')[0])
                                {
                                    Console.WriteLine(vw[vw.Length - 1].Split(' ')[vw[vw.Length - 1].Split(' ').Length - 1]);
                                    if (vm[vm.Length - 1] == vw[vw.Length - 1].Split(' ')[vw[vw.Length - 1].Split(' ').Length - 1])
                                    {
                                        if (int.Parse(vw[0].Split(')')[0].Substring(vw[0].Split(')')[0].Length - 1)) <= int.Parse(tier))
                                        {
                                            WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("成功!恭喜!");
                                            return;
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                    }
                                    else
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                }
                                else
                                {
                                    if (k == AffixArray.Length - 1)
                                    {
                                        WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                        RightClickchaos();
                                        Thread.Sleep(Ms);
                                        LeftClickammour();
                                    }
                                    else
                                    {
                                        WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                    }
                                }
                            }
                        }


                    }
                    else // check == false
                    {
                        string[] vm = Affix[j].Split(' ');
                        for (int k = b + 1; k < AffixArray.Length; k++)
                        {

                            string[] vw = AffixArray[k].Split('\n');
                            vw = vw[1].Split(' ');
                            if (vw.Length != Affix[j].Split(' ').Length)
                            {
                                if (k == AffixArray.Length - 1)
                                {
                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                    WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                    RightClickchaos();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                }
                                else
                                {
                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                }
                            }
                            else
                            {
                                if (Affix[j].Split(' ').Length == 2)
                                {
                                    if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                    {
                                        WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        WorkLog.AppendText("成功!恭喜!");
                                        return;

                                    }
                                    else
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                }
                                else if (vm[0] == vw[0])
                                {
                                    if (vm[Affix[j].Split(' ').Length - 1] == vw[vw.Length - 1])
                                    {
                                        WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        WorkLog.AppendText("成功!恭喜!");
                                        return;
                                    }
                                    else
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《混沌石》\r\n");
                                            RightClickchaos();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                }
                                else
                                {
                                    if (k == AffixArray.Length - 1)
                                    {
                                        WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        WorkLog.AppendText("第" + i + "次點《改造石》\r\n");
                                        RightClickchaos();
                                        Thread.Sleep(Ms);
                                        LeftClickammour();
                                    }
                                    else
                                    {
                                        WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                    }
                                }
                            }
                        }

                    }
                }

            }
        }
    }
}

/*
        private void UseAug(string[] Affix, int successAffix, int workNum, int Ms)
        {
            for (int i = 1; i < workNum + 1; i++)
            {
                //string[] PreorSuf = [];
                Thread.Sleep(Ms);
                MoveToammour();
                Thread.Sleep(100);
                SendKeys.Send("%^{C}");
                Thread.Sleep(Ms);
                string a = Clipboard.GetText(TextDataFormat.Text);
                string[] AffixArray = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (AffixArray[AffixArray.Length - 1].Contains("塑界者") ||
                    AffixArray[AffixArray.Length - 1].Contains("異界尊師") ||
                    AffixArray[AffixArray.Length - 1].Contains("聖戰士") ||
                    AffixArray[AffixArray.Length - 1].Contains("救贖者") ||
                    AffixArray[AffixArray.Length - 1].Contains("狩獵者") ||
                    AffixArray[AffixArray.Length - 1].Contains("總督軍"))
                {
                    Array.Resize(ref AffixArray, AffixArray.Length - 2);
                }
                int b = Array.FindLastIndex(AffixArray,
                element => element.StartsWith("--------",
                StringComparison.Ordinal));
                string Rarity = AffixArray[1].Substring(5);
                if (Rarity == "普通")
                {
                    RightClicktrans();
                    Thread.Sleep(Ms);
                    LeftClickammour();
                }
                else if (Rarity == "魔法")
                {
                    for (int j = 0; j < Affix.Length; j++)
                    {
                        bool check = Regex.IsMatch(Affix[j], @"@");
                        if (check == true)
                        {

                            string[] vs = Affix[j].Split('@');
                            vs = vs[1].Split('~');
                            //AffixArray是裝備
                            //Affix是設定的詞綴
                            int min = Int32.Parse(vs[0]);
                            int max = Int32.Parse(vs[1]);
                            string[] vm = Affix[j].Split('@')[0].Split(' ');
                            for (int k = b + 1; k < AffixArray.Length; k++)
                            {
                                float numers = 0;
                                float numersMin = 0;
                                float numersMax = 0;
                                string[] vw = AffixArray[k].Split('\n');
                                if (vw[0].Split(' ')[1].Substring(0, 1) == PreOrSuf.SelectedItem.ToString() &&
                                    k == b + 1 &&
                                    AffixArray.Length - (b + 1) == 1 &&
                                    augCheck.Checked == true)
                                {
                                    WorkLog.AppendText("【 X 】" + vw[1] + "\r\n");
                                    WorkLog.AppendText("使用增幅石\r\n");
                                    RightClickaug();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                    i--;
                                }
                                else
                                {
                                    vw = vw[1].Split(' ');
                                    if(vw.Length != Affix[j].Split(' ').Length)
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                            RightClickalt();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }else
                                    {
                                        if (Affix[j].Split(' ').Length == 2)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                if (vw[0].Split('(')[0].Contains("+"))
                                                {
                                                    numers = float.Parse(vw[0].Split('(')[0].Substring(1));
                                                }
                                                else
                                                {
                                                    numers = float.Parse(vw[0].Split('(')[0]);
                                                }
                                                if (numers >= min || numers <= max)
                                                {
                                                    WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("成功!恭喜!");
                                                    return;
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }

                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (vm[0] == vw[0])
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                if (Affix[j].Split(' ').Length == 3)
                                                {

                                                    if (vw[1].Contains("%"))
                                                    {
                                                        numers = float.Parse(vw[1].Split('(')[0]);
                                                        Console.WriteLine(numers);
                                                    }
                                                    else
                                                    {
                                                        numers = float.Parse(vw[1].Substring(0, vw[1].Length - 1));
                                                    }

                                                }
                                                else
                                                {
                                                    numersMin = float.Parse(vw[1].Split('(')[0]);
                                                    numersMax = float.Parse(vw[3].Split('(')[0]);
                                                }
                                                if (Affix[j].Split(' ').Length == 5)
                                                {
                                                    if (numersMin >= min && numersMax <= max)
                                                    {
                                                        WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                        WorkLog.AppendText("成功!恭喜!");
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                        WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                        RightClickalt();
                                                        Thread.Sleep(Ms);
                                                        LeftClickammour();
                                                    }
                                                }
                                                else
                                                {
                                                    if (numers >= min || numers <= max)
                                                    {
                                                        WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                        WorkLog.AppendText("成功!恭喜!");
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        if (k == AffixArray.Length - 1)
                                                        {
                                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                            WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                            RightClickalt();
                                                            Thread.Sleep(Ms);
                                                            LeftClickammour();
                                                        }
                                                        else
                                                        {
                                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                        }
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k == AffixArray.Length - 1)
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                RightClickalt();
                                                Thread.Sleep(Ms);
                                                LeftClickammour();
                                            }
                                            else
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            }
                                        }
                                    }
                                }
                            }


                        }
                        else // check == false
                        {
                            string[] vm = Affix[j].Split(' ');
                             for (int k = b + 1; k < AffixArray.Length; k++)
                            {

                                string[] vw = AffixArray[k].Split('\n');
                                if (vw[0].Split(' ')[1].Substring(0, 1) == PreOrSuf.SelectedItem.ToString() &&
                                    k == b + 1 &&
                                    AffixArray.Length - (b + 1) == 1&&
                                    augCheck.Checked == true)
                                {
                                    WorkLog.AppendText("【 X 】" + vw[1] + "\r\n");
                                    WorkLog.AppendText("使用增幅石\r\n");
                                    RightClickaug();
                                    Thread.Sleep(Ms);
                                    LeftClickammour();
                                    i--;
                                }
                                else
                                {
                                    vw = vw[1].Split(' ');
                                    if(vw.Length != Affix[j].Split(' ').Length)
                                    {
                                        if (k == AffixArray.Length - 1)
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                            RightClickalt();
                                            Thread.Sleep(Ms);
                                            LeftClickammour();
                                        }
                                        else
                                        {
                                            WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                        }
                                    }
                                    else
                                    {
                                        if (Affix[j].Split(' ').Length == 2)
                                        {
                                            if (vm[vm.Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;

                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else if (vm[0] == vw[0])
                                        {
                                            if (vm[Affix[j].Split(' ').Length - 1] == vw[vw.Length - 1])
                                            {
                                                WorkLog.AppendText("【 O 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("成功!恭喜!");
                                                return;
                                            }
                                            else
                                            {
                                                if (k == AffixArray.Length - 1)
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                    WorkLog.AppendText("第" + (i + 1) + "次點《改造石》\r\n");
                                                    RightClickalt();
                                                    Thread.Sleep(Ms);
                                                    LeftClickammour();
                                                }
                                                else
                                                {
                                                    WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (k == AffixArray.Length - 1)
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                                WorkLog.AppendText("第" + i + "次點《改造石》\r\n");
                                                RightClickalt();
                                                Thread.Sleep(Ms);
                                                LeftClickammour();
                                            }
                                            else
                                            {
                                                WorkLog.AppendText("【 X 】" + AffixArray[k].Split('\n')[1] + "\r\n");
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                else if (Rarity == "稀有")
                {
                    RightClickscour();
                    Thread.Sleep(Ms);
                    LeftClickammour();
                }

            }
        }
*/
