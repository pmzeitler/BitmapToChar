using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapToChar
{
    public partial class Form1 : Form
    {
        private char row0Value = (char) 0;
        private char row1Value = (char) 0;
        private char row2Value = (char)0;
        private char row3Value = (char)0;
        private char row4Value = (char)0;
        private char row5Value = (char)0;
        private char row6Value = (char)0;
        private char row7Value = (char)0;

        private bool doUpdateFulls = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            row0_128.Click += new EventHandler(row0_128_Click);
            row0_64.Click += new EventHandler(row0_64_Click);
            row0_32.Click += new EventHandler(row0_32_Click);
            row0_16.Click += new EventHandler(row0_16_Click);
            row0_8.Click += new EventHandler(row0_8_Click);
            row0_4.Click += new EventHandler(row0_4_Click);
            row0_2.Click += new EventHandler(row0_2_Click);
            row0_1.Click += new EventHandler(row0_1_Click);

            row1_128.Click += new EventHandler(row1_128_Click);
            row1_64.Click += new EventHandler(row1_64_Click);
            row1_32.Click += new EventHandler(row1_32_Click);
            row1_16.Click += new EventHandler(row1_16_Click);
            row1_8.Click += new EventHandler(row1_8_Click);
            row1_4.Click += new EventHandler(row1_4_Click);
            row1_2.Click += new EventHandler(row1_2_Click);
            row1_1.Click += new EventHandler(row1_1_Click);

            row2_128.Click += new EventHandler(row2_128_Click);
            row2_64.Click += new EventHandler(row2_64_Click);
            row2_32.Click += new EventHandler(row2_32_Click);
            row2_16.Click += new EventHandler(row2_16_Click);
            row2_8.Click += new EventHandler(row2_8_Click);
            row2_4.Click += new EventHandler(row2_4_Click);
            row2_2.Click += new EventHandler(row2_2_Click);
            row2_1.Click += new EventHandler(row2_1_Click);

            row3_128.Click += new EventHandler(row3_128_Click);
            row3_64.Click += new EventHandler(row3_64_Click);
            row3_32.Click += new EventHandler(row3_32_Click);
            row3_16.Click += new EventHandler(row3_16_Click);
            row3_8.Click += new EventHandler(row3_8_Click);
            row3_4.Click += new EventHandler(row3_4_Click);
            row3_2.Click += new EventHandler(row3_2_Click);
            row3_1.Click += new EventHandler(row3_1_Click);

            row4_128.Click += new EventHandler(row4_128_Click);
            row4_64.Click += new EventHandler(row4_64_Click);
            row4_32.Click += new EventHandler(row4_32_Click);
            row4_16.Click += new EventHandler(row4_16_Click);
            row4_8.Click += new EventHandler(row4_8_Click);
            row4_4.Click += new EventHandler(row4_4_Click);
            row4_2.Click += new EventHandler(row4_2_Click);
            row4_1.Click += new EventHandler(row4_1_Click);

            row5_128.Click += new EventHandler(row5_128_Click);
            row5_64.Click += new EventHandler(row5_64_Click);
            row5_32.Click += new EventHandler(row5_32_Click);
            row5_16.Click += new EventHandler(row5_16_Click);
            row5_8.Click += new EventHandler(row5_8_Click);
            row5_4.Click += new EventHandler(row5_4_Click);
            row5_2.Click += new EventHandler(row5_2_Click);
            row5_1.Click += new EventHandler(row5_1_Click);

            row6_128.Click += new EventHandler(row6_128_Click);
            row6_64.Click += new EventHandler(row6_64_Click);
            row6_32.Click += new EventHandler(row6_32_Click);
            row6_16.Click += new EventHandler(row6_16_Click);
            row6_8.Click += new EventHandler(row6_8_Click);
            row6_4.Click += new EventHandler(row6_4_Click);
            row6_2.Click += new EventHandler(row6_2_Click);
            row6_1.Click += new EventHandler(row6_1_Click);

            row7_128.Click += new EventHandler(row7_128_Click);
            row7_64.Click += new EventHandler(row7_64_Click);
            row7_32.Click += new EventHandler(row7_32_Click);
            row7_16.Click += new EventHandler(row7_16_Click);
            row7_8.Click += new EventHandler(row7_8_Click);
            row7_4.Click += new EventHandler(row7_4_Click);
            row7_2.Click += new EventHandler(row7_2_Click);
            row7_1.Click += new EventHandler(row7_1_Click);

            updateRow0();
            updateRow1();
            updateRow2();
            updateRow3();
            updateRow4();
            updateRow5();
            updateRow6();
            doUpdateFulls = true;
            updateRow7();
        }


        private void row0_128_Click(object sender, EventArgs e)
        {
            switch (row0_128.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }
        private void row0_64_Click(object sender, EventArgs e)
        {
            switch (row0_64.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_32_Click(object sender, EventArgs e)
        {
            switch (row0_32.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_16_Click(object sender, EventArgs e)
        {
            switch (row0_16.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_8_Click(object sender, EventArgs e)
        {
            switch (row0_8.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_4_Click(object sender, EventArgs e)
        {
            switch (row0_4.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_2_Click(object sender, EventArgs e)
        {
            switch (row0_2.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row0_1_Click(object sender, EventArgs e)
        {
            switch (row0_1.CheckState)
            {
                case CheckState.Checked:
                    row0Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row0Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow0();
        }

        private void row1_128_Click(object sender, EventArgs e)
        {
            switch (row1_128.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }
        private void row1_64_Click(object sender, EventArgs e)
        {
            switch (row1_64.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_32_Click(object sender, EventArgs e)
        {
            switch (row1_32.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_16_Click(object sender, EventArgs e)
        {
            switch (row1_16.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_8_Click(object sender, EventArgs e)
        {
            switch (row1_8.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_4_Click(object sender, EventArgs e)
        {
            switch (row1_4.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_2_Click(object sender, EventArgs e)
        {
            switch (row1_2.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row1_1_Click(object sender, EventArgs e)
        {
            switch (row1_1.CheckState)
            {
                case CheckState.Checked:
                    row1Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row1Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow1();
        }

        private void row2_128_Click(object sender, EventArgs e)
        {
            switch (row2_128.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }
        private void row2_64_Click(object sender, EventArgs e)
        {
            switch (row2_64.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_32_Click(object sender, EventArgs e)
        {
            switch (row2_32.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_16_Click(object sender, EventArgs e)
        {
            switch (row2_16.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_8_Click(object sender, EventArgs e)
        {
            switch (row2_8.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_4_Click(object sender, EventArgs e)
        {
            switch (row2_4.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_2_Click(object sender, EventArgs e)
        {
            switch (row2_2.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row2_1_Click(object sender, EventArgs e)
        {
            switch (row2_1.CheckState)
            {
                case CheckState.Checked:
                    row2Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row2Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow2();
        }

        private void row3_128_Click(object sender, EventArgs e)
        {
            switch (row3_128.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }
        private void row3_64_Click(object sender, EventArgs e)
        {
            switch (row3_64.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_32_Click(object sender, EventArgs e)
        {
            switch (row3_32.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_16_Click(object sender, EventArgs e)
        {
            switch (row3_16.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_8_Click(object sender, EventArgs e)
        {
            switch (row3_8.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_4_Click(object sender, EventArgs e)
        {
            switch (row3_4.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_2_Click(object sender, EventArgs e)
        {
            switch (row3_2.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row3_1_Click(object sender, EventArgs e)
        {
            switch (row3_1.CheckState)
            {
                case CheckState.Checked:
                    row3Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row3Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow3();
        }

        private void row4_128_Click(object sender, EventArgs e)
        {
            switch (row4_128.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }
        private void row4_64_Click(object sender, EventArgs e)
        {
            switch (row4_64.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_32_Click(object sender, EventArgs e)
        {
            switch (row4_32.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_16_Click(object sender, EventArgs e)
        {
            switch (row4_16.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_8_Click(object sender, EventArgs e)
        {
            switch (row4_8.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_4_Click(object sender, EventArgs e)
        {
            switch (row4_4.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_2_Click(object sender, EventArgs e)
        {
            switch (row4_2.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row4_1_Click(object sender, EventArgs e)
        {
            switch (row4_1.CheckState)
            {
                case CheckState.Checked:
                    row4Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row4Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow4();
        }

        private void row5_128_Click(object sender, EventArgs e)
        {
            switch (row5_128.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }
        private void row5_64_Click(object sender, EventArgs e)
        {
            switch (row5_64.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_32_Click(object sender, EventArgs e)
        {
            switch (row5_32.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_16_Click(object sender, EventArgs e)
        {
            switch (row5_16.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_8_Click(object sender, EventArgs e)
        {
            switch (row5_8.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_4_Click(object sender, EventArgs e)
        {
            switch (row5_4.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_2_Click(object sender, EventArgs e)
        {
            switch (row5_2.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }

        private void row5_1_Click(object sender, EventArgs e)
        {
            switch (row5_1.CheckState)
            {
                case CheckState.Checked:
                    row5Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row5Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow5();
        }
        private void row6_128_Click(object sender, EventArgs e)
        {
            switch (row6_128.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }
        private void row6_64_Click(object sender, EventArgs e)
        {
            switch (row6_64.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_32_Click(object sender, EventArgs e)
        {
            switch (row6_32.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_16_Click(object sender, EventArgs e)
        {
            switch (row6_16.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_8_Click(object sender, EventArgs e)
        {
            switch (row6_8.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_4_Click(object sender, EventArgs e)
        {
            switch (row6_4.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_2_Click(object sender, EventArgs e)
        {
            switch (row6_2.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row6_1_Click(object sender, EventArgs e)
        {
            switch (row6_1.CheckState)
            {
                case CheckState.Checked:
                    row6Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row6Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow6();
        }

        private void row7_128_Click(object sender, EventArgs e)
        {
            switch (row7_128.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)128;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)128;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }
        private void row7_64_Click(object sender, EventArgs e)
        {
            switch (row7_64.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)64;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)64;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_32_Click(object sender, EventArgs e)
        {
            switch (row7_32.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)32;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)32;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_16_Click(object sender, EventArgs e)
        {
            switch (row7_16.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)16;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)16;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_8_Click(object sender, EventArgs e)
        {
            switch (row7_8.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)8;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)8;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_4_Click(object sender, EventArgs e)
        {
            switch (row7_4.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)4;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)4;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_2_Click(object sender, EventArgs e)
        {
            switch (row7_2.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)2;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)2;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void row7_1_Click(object sender, EventArgs e)
        {
            switch (row7_1.CheckState)
            {
                case CheckState.Checked:
                    row7Value += (char)1;
                    break;
                case CheckState.Unchecked:
                    row7Value -= (char)1;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            updateRow7();
        }

        private void updateRow0()
        {
            row0_dec.Text = String.Format("{0:D2}", (int)row0Value);
            row0_hex.Text = String.Format("0x{0:X2}", (int)row0Value);
            updateFulls();
        }
        private void updateRow1()
        {
            row1_dec.Text = String.Format("{0:D2}", (int)row1Value);
            row1_hex.Text = String.Format("0x{0:X2}", (int)row1Value);
            updateFulls();
        }
        private void updateRow2()
        {
            row2_dec.Text = String.Format("{0:D2}", (int)row2Value);
            row2_hex.Text = String.Format("0x{0:X2}", (int)row2Value);
            updateFulls();
        }
        private void updateRow3()
        {
            row3_dec.Text = String.Format("{0:D2}", (int)row3Value);
            row3_hex.Text = String.Format("0x{0:X2}", (int)row3Value);
            updateFulls();
        }
        private void updateRow4()
        {
            row4_dec.Text = String.Format("{0:D2}", (int)row4Value);
            row4_hex.Text = String.Format("0x{0:X2}", (int)row4Value);
            updateFulls();
        }
        private void updateRow5()
        {
            row5_dec.Text = String.Format("{0:D2}", (int)row5Value);
            row5_hex.Text = String.Format("0x{0:X2}", (int)row5Value);
            updateFulls();
        }
        private void updateRow6()
        {
            row6_dec.Text = String.Format("{0:D2}", (int)row6Value);
            row6_hex.Text = String.Format("0x{0:X2}", (int)row6Value);
            updateFulls();
        }
        private void updateRow7()
        {
            row7_dec.Text = String.Format("{0:D2}", (int)row7Value);
            row7_hex.Text = String.Format("0x{0:X2}", (int)row7Value);
            updateFulls();
        }

        private void updateFulls()
        {
            if (doUpdateFulls)
            {
                full_dec.Text = $"{row0_dec.Text},{row1_dec.Text},{row2_dec.Text},{row3_dec.Text},{row4_dec.Text},{row5_dec.Text},{row6_dec.Text},{row7_dec.Text}";
                full_hex.Text = $"{row0_hex.Text},{row1_hex.Text},{row2_hex.Text},{row3_hex.Text},{row4_hex.Text},{row5_hex.Text},{row6_hex.Text},{row7_hex.Text}";
            }
        }

        private void copy_dec_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(full_dec.Text);
        }
        private void copy_hex_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(full_hex.Text);
        }

        private void clear_all_click(object sender, EventArgs e)
        {
            row0_128.Checked = false;
            row0_64.Checked = false;
            row0_32.Checked = false;
            row0_16.Checked = false;
            row0_8.Checked = false;
            row0_4.Checked = false;
            row0_2.Checked = false;
            row0_1.Checked = false;
            row0Value = (char)0;

            row1_128.Checked = false;
            row1_64.Checked = false;
            row1_32.Checked = false;
            row1_16.Checked = false;
            row1_8.Checked = false;
            row1_4.Checked = false;
            row1_2.Checked = false;
            row1_1.Checked = false;
            row1Value = (char)0;

            row2_128.Checked = false;
            row2_64.Checked = false;
            row2_32.Checked = false;
            row2_16.Checked = false;
            row2_8.Checked = false;
            row2_4.Checked = false;
            row2_2.Checked = false;
            row2_1.Checked = false;
            row2Value = (char)0;

            row3_128.Checked = false;
            row3_64.Checked = false;
            row3_32.Checked = false;
            row3_16.Checked = false;
            row3_8.Checked = false;
            row3_4.Checked = false;
            row3_2.Checked = false;
            row3_1.Checked = false;
            row3Value = (char)0;

            row4_128.Checked = false;
            row4_64.Checked = false;
            row4_32.Checked = false;
            row4_16.Checked = false;
            row4_8.Checked = false;
            row4_4.Checked = false;
            row4_2.Checked = false;
            row4_1.Checked = false;
            row4Value = (char)0;

            row5_128.Checked = false;
            row5_64.Checked = false;
            row5_32.Checked = false;
            row5_16.Checked = false;
            row5_8.Checked = false;
            row5_4.Checked = false;
            row5_2.Checked = false;
            row5_1.Checked = false;
            row5Value = (char)0;

            row6_128.Checked = false;
            row6_64.Checked = false;
            row6_32.Checked = false;
            row6_16.Checked = false;
            row6_8.Checked = false;
            row6_4.Checked = false;
            row6_2.Checked = false;
            row6_1.Checked = false;
            row6Value = (char)0;

            row7_128.Checked = false;
            row7_64.Checked = false;
            row7_32.Checked = false;
            row7_16.Checked = false;
            row7_8.Checked = false;
            row7_4.Checked = false;
            row7_2.Checked = false;
            row7_1.Checked = false;
            row7Value = (char)0;

            doUpdateFulls = false;
            updateRow0();
            updateRow1();
            updateRow2();
            updateRow3();
            updateRow4();
            updateRow5();
            updateRow6();
            doUpdateFulls = true;
            updateRow7();
        }


    }
}
