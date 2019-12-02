using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainFuckInterpreter
{
    public partial class Form1 : Form
    {
        public static int regLen = 16;

        public Form1()
        {
            InitializeComponent();
        }

        Font regIndFont = new Font("Arial", 20);
        Font regValFont = new Font("Arial", 15);

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < regLen; i++) {
                TextBox pRegInd = new TextBox();
                pRegInd.Top = 3;
                pRegInd.Width = 40;
                pRegInd.Height = 40;
                pRegInd.Left = 3 + (i * 43);
                pRegInd.Text = i.ToString();
                pRegInd.Font = regIndFont;
                pRegInd.ReadOnly = true;
                pRegInd.TextAlign = HorizontalAlignment.Center;

                TextBox pRegVal = new TextBox();
                pRegVal.Top = 49;
                pRegVal.Width = 40;
                pRegVal.Height = 40;
                pRegVal.Left = 3 + (i * 43);
                pRegVal.Text = "000";
                pRegVal.Font = regValFont;
                pRegVal.ReadOnly = true;

                pRegistry.Controls.Add(pRegInd);
                pRegistry.Controls.Add(pRegVal);

                memory[i] = 0;
                memoryView[i] = pRegVal;
            }

        }

        TextBox[] memoryView = new TextBox[regLen];
        byte[] memory = new byte[regLen];

        void WriteRegistry()
        {
            for (int i = 0; i < regLen; i++)
            {
                memoryView[i].Text = memory[i].ToString();
            }
        }
        public char[] SubArray(char[] data, int index, int length)
        {
            char[] result = new char[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
        char[] subLoop(char[] AllCode, int codeInd)
        {
            int startInd = 0;
            int endInd = 0;
            for (int i = codeInd; i < AllCode.Length; i++)
            {
                if (AllCode[i] == '[') { startInd = i+1; break; }
            }
            int amtOpenBrack = 0;
            for (int i = startInd+1; i < AllCode.Length; i++)
            {
                if (AllCode[i] == '[') { amtOpenBrack++; }
                    if (AllCode[i] == ']') { if (amtOpenBrack == 0) { endInd = i; break; } else { amtOpenBrack--; } }
            }
            return SubArray(AllCode, startInd, endInd - startInd);
        }

        string runCode(char[] code, char[] input, int regInd, int codeInd, int inputInd)
        {
            //int regInd = 0;
            //int codeInd = 0;
            //int inputInd = 0;

            string output = "";
            while (codeInd < code.Length)
            {
                if (code[codeInd] == '+') { if (memory[regInd] < 255) { memory[regInd]++; } else if (memory[regInd] == 255) { memory[regInd] = 0; } }
                if (code[codeInd] == '-') { if (memory[regInd] > 0) { memory[regInd]--; } else if (memory[regInd] == 0) { memory[regInd] = 255; } }
                if (code[codeInd] == '>') { if (regInd != regLen - 1) { regInd++; } else { regInd = 0; } }
                if (code[codeInd] == '<') { if (regInd > 0) { regInd--; } else { regInd = regLen - 1; } }
                if (code[codeInd] == '.') { output += (char)memory[regInd]; }
                if (code[codeInd] == ',') { memory[regInd] = (byte)input[inputInd]; inputInd++; }
                if (code[codeInd] == '[') {
                    char[] subL = subLoop(code, codeInd);
                    while (memory[regInd] != 0) {
                        runCode(subL,input,regInd,0,inputInd);
                    }
                    codeInd += subL.Length+1;
                }
                codeInd++;
                WriteRegistry();
            }

            return output;
        }

        void ResetRegisrty()
        {
            for (int i = 0; i < regLen; i++)
            {
                memory[i] = 0;
            }
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            ResetRegisrty();
            rtbOutput.Text = runCode(rtbBrainFuckCode.Text.ToArray(), tbInput.Text.ToArray(),0,0,0);
        }

        private void tbInput_Click(object sender, EventArgs e)
        {
            if (tbInput.Tag.ToString() != "1") { tbInput.Text = ""; tbInput.Tag = "1"; }
        }

        private void rtbBrainFuckCode_Click(object sender, EventArgs e)
        {
            if (rtbBrainFuckCode.Tag.ToString() != "1") { rtbBrainFuckCode.Text = ""; rtbBrainFuckCode.Tag = "1"; }
        }
    }
}
