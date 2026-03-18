namespace java_rpg_gdx_lvleditor
{
    public partial class Form1 : Form
    {
        int b1Status = 0;
        int b2Status = 0;
        int b3Status = 0;
        int b4Status = 0;
        int b5Status = 0;
        int b6Status = 0;
        int b7Status = 0;
        int b8Status = 0;
        int b9Status = 0;
        int b10Status = 0;
        int b11Status = 0;
        int b12Status = 0;
        int b13Status = 0;
        int b14Status = 0;
        int b15Status = 0;
        int b16Status = 0;
        int b17Status = 0;
        int b18Status = 0;
        int b19Status = 0;
        int b20Status = 0;
        int b21Status = 0;
        int b22Status = 0;
        int b23Status = 0;
        int b24Status = 0;
        int b25Status = 0;
        int b26Status = 0;
        int b27Status = 0;
        int b28Status = 0;
        int b29Status = 0;
        int b30Status = 0;
        int b31Status = 0;
        int b32Status = 0;
        int b33Status = 0;
        int b34Status = 0;
        int b35Status = 0;
        int b36Status = 0;
        int b37Status = 0;
        int b38Status = 0;
        int b39Status = 0;
        int b40Status = 0;
        int b41Status = 0;
        int b42Status = 0;
        int b43Status = 0;
        int b44Status = 0;
        int b45Status = 0;
        int b46Status = 0;
        int b47Status = 0;
        int b48Status = 0;
        int b49Status = 0;
        int b50Status = 0;
        int b51Status = 0;
        int b52Status = 0;
        int b53Status = 0;
        int b54Status = 0;
        int b55Status = 0;
        int b56Status = 0;
        int b57Status = 0;
        int b58Status = 0;
        int b59Status = 0;
        int b60Status = 0;
        int b61Status = 0;
        int b62Status = 0;
        int b63Status = 0;
        int b64Status = 0;

        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // Wire button click events so labels update when clicked
            b1.Click += b1_Click; b2.Click += b2_Click; b3.Click += b3_Click; b4.Click += b4_Click;
            b5.Click += b5_Click; b6.Click += b6_Click; b7.Click += b7_Click; b8.Click += b8_Click;
            b9.Click += b9_Click; b10.Click += b10_Click; b11.Click += b11_Click; b12.Click += b12_Click;
            b13.Click += b13_Click; b14.Click += b14_Click; b15.Click += b15_Click; b16.Click += b16_Click;
            b17.Click += b17_Click; b18.Click += b18_Click; b19.Click += b19_Click; b20.Click += b20_Click;
            b21.Click += b21_Click; b22.Click += b22_Click; b23.Click += b23_Click; b24.Click += b24_Click;
            b25.Click += b25_Click; b26.Click += b26_Click; b27.Click += b27_Click; b28.Click += b28_Click;
            b29.Click += b29_Click; b30.Click += b30_Click; b31.Click += b31_Click; b32.Click += b32_Click;
            b33.Click += b33_Click; b34.Click += b34_Click; b35.Click += b35_Click; b36.Click += b36_Click;
            b37.Click += b37_Click; b38.Click += b38_Click; b39.Click += b39_Click; b40.Click += b40_Click;
            b41.Click += b41_Click; b42.Click += b42_Click; b43.Click += b43_Click; b44.Click += b44_Click;
            b45.Click += b45_Click; b46.Click += b46_Click; b47.Click += b47_Click; b48.Click += b48_Click;
            b49.Click += b49_Click; b50.Click += b50_Click; b51.Click += b51_Click; b52.Click += b52_Click;
            b53.Click += b53_Click; b54.Click += b54_Click; b55.Click += b55_Click; b56.Click += b56_Click;
            b57.Click += b57_Click; b58.Click += b58_Click; b59.Click += b59_Click; b60.Click += b60_Click;
            b61.Click += b61_Click; b62.Click += b62_Click; b63.Click += b63_Click; b64.Click += b64_Click;

            // Ensure button labels reflect current status values
            b1.Text = b1Status.ToString(); b2.Text = b2Status.ToString(); b3.Text = b3Status.ToString(); b4.Text = b4Status.ToString();
            b5.Text = b5Status.ToString(); b6.Text = b6Status.ToString(); b7.Text = b7Status.ToString(); b8.Text = b8Status.ToString();
            b9.Text = b9Status.ToString(); b10.Text = b10Status.ToString(); b11.Text = b11Status.ToString(); b12.Text = b12Status.ToString();
            b13.Text = b13Status.ToString(); b14.Text = b14Status.ToString(); b15.Text = b15Status.ToString(); b16.Text = b16Status.ToString();
            b17.Text = b17Status.ToString(); b18.Text = b18Status.ToString(); b19.Text = b19Status.ToString(); b20.Text = b20Status.ToString();
            b21.Text = b21Status.ToString(); b22.Text = b22Status.ToString(); b23.Text = b23Status.ToString(); b24.Text = b24Status.ToString();
            b25.Text = b25Status.ToString(); b26.Text = b26Status.ToString(); b27.Text = b27Status.ToString(); b28.Text = b28Status.ToString();
            b29.Text = b29Status.ToString(); b30.Text = b30Status.ToString(); b31.Text = b31Status.ToString(); b32.Text = b32Status.ToString();
            b33.Text = b33Status.ToString(); b34.Text = b34Status.ToString(); b35.Text = b35Status.ToString(); b36.Text = b36Status.ToString();
            b37.Text = b37Status.ToString(); b38.Text = b38Status.ToString(); b39.Text = b39Status.ToString(); b40.Text = b40Status.ToString();
            b41.Text = b41Status.ToString(); b42.Text = b42Status.ToString(); b43.Text = b43Status.ToString(); b44.Text = b44Status.ToString();
            b45.Text = b45Status.ToString(); b46.Text = b46Status.ToString(); b47.Text = b47Status.ToString(); b48.Text = b48Status.ToString();
            b49.Text = b49Status.ToString(); b50.Text = b50Status.ToString(); b51.Text = b51Status.ToString(); b52.Text = b52Status.ToString();
            b53.Text = b53Status.ToString(); b54.Text = b54Status.ToString(); b55.Text = b55Status.ToString(); b56.Text = b56Status.ToString();
            b57.Text = b57Status.ToString(); b58.Text = b58Status.ToString(); b59.Text = b59Status.ToString(); b60.Text = b60Status.ToString();
            b61.Text = b61Status.ToString(); b62.Text = b62Status.ToString(); b63.Text = b63Status.ToString(); b64.Text = b64Status.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1Status <= 4)
            {
                b1Status++;
            }
            else
            {
                b1Status = 0;

            }
            b1.Text = b1Status.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2Status <= 4)
            {
                b2Status++;
            }
            else
            {
                b2Status = 0;

            }
            b2.Text = b2Status.ToString();
        }
        private void b3_Click(object sender, EventArgs e)
        {
            if (b3Status <= 4)
            {
                b3Status++;
            }
            else
            {
                b3Status = 0;

            }
            b3.Text = b3Status.ToString();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            if (b4Status <= 4)
            {
                b4Status++;
            }
            else
            {
                b4Status = 0;

            }
            b4.Text = b4Status.ToString();
        }
        private void b5_Click(object sender, EventArgs e)
        {
            if (b5Status <= 4)
            {
                b5Status++;
            }
            else
            {
                b5Status = 0;
            }
            b5.Text = b5Status.ToString();
        }
        private void b6_Click(object sender, EventArgs e)
        {
            if (b6Status <= 4)
            {
                b6Status++;
            }
            else
            {
                b6Status = 0;
            }
            b6.Text = b6Status.ToString();
        }
        private void b7_Click(object sender, EventArgs e)
        {
            if (b7Status <= 4)
            {
                b7Status++;
            }
            else
            {
                b7Status = 0;
            }
            b7.Text = b7Status.ToString();
        }
        private void b8_Click(object sender, EventArgs e)
        {
            if (b8Status <= 4)
            {
                b8Status++;
            }
            else
            {
                b8Status = 0;
            }
            b8.Text = b8Status.ToString();
        }
        private void b9_Click(object sender, EventArgs e)
        {
            if (b9Status <= 4)
            {
                b9Status++;
            }
            else
            {
                b9Status = 0;
            }
            b9.Text = b9Status.ToString();
        }
        private void b10_Click(object sender, EventArgs e)
        {
            if (b10Status <= 4)
            {
                b10Status++;
            }
            else
            {
                b10Status = 0;
            }
            b10.Text = b10Status.ToString();
        }
        private void b11_Click(object sender, EventArgs e)
        {
            if (b11Status <= 4)
            {
                b11Status++;
            }
            else
            {
                b11Status = 0;
            }
            b11.Text = b11Status.ToString();
        }
        private void b12_Click(object sender, EventArgs e)
        {
            if (b12Status <= 4)
            {
                b12Status++;
            }
            else
            {
                b12Status = 0;
            }
            b12.Text = b12Status.ToString();
        }
        private void b13_Click(object sender, EventArgs e)
        {
            if (b13Status <= 4)
            {
                b13Status++;
            }
            else
            {
                b13Status = 0;
            }
            b13.Text = b13Status.ToString();
        }
        private void b14_Click(object sender, EventArgs e)
        {
            if (b14Status <= 4)
            {
                b14Status++;
            }
            else
            {
                b14Status = 0;
            }
            b14.Text = b14Status.ToString();
        }
        private void b15_Click(object sender, EventArgs e)
        {
            if (b15Status <= 4)
            {
                b15Status++;
            }
            else
            {
                b15Status = 0;
            }
            b15.Text = b15Status.ToString();
        }
        private void b16_Click(object sender, EventArgs e)
        {
            if (b16Status <= 4)
            {
                b16Status++;
            }
            else
            {
                b16Status = 0;
            }
            b16.Text = b16Status.ToString();
        }
        private void b17_Click(object sender, EventArgs e)
        {
            if (b17Status <= 4)
            {
                b17Status++;
            }
            else
            {
                b17Status = 0;
            }
            b17.Text = b17Status.ToString();
        }
        private void b18_Click(object sender, EventArgs e)
        {
            if (b18Status <= 4)
            {
                b18Status++;
            }
            else
            {
                b18Status = 0;
            }
            b18.Text = b18Status.ToString();
        }
        private void b19_Click(object sender, EventArgs e)
        {
            if (b19Status <= 4)
            {
                b19Status++;
            }
            else
            {
                b19Status = 0;
            }
            b19.Text = b19Status.ToString();
        }
        private void b20_Click(object sender, EventArgs e)
        {
            if (b20Status <= 4)
            {
                b20Status++;
            }
            else
            {
                b20Status = 0;
            }
            b20.Text = b20Status.ToString();
        }
        private void b21_Click(object sender, EventArgs e)
        {
            if (b21Status <= 4)
            {
                b21Status++;
            }
            else
            {
                b21Status = 0;
            }
            b21.Text = b21Status.ToString();
        }
        private void b22_Click(object sender, EventArgs e)
        {
            if (b22Status <= 4)
            {
                b22Status++;
            }
            else
            {
                b22Status = 0;
            }
            b22.Text = b22Status.ToString();
        }
        private void b23_Click(object sender, EventArgs e)
        {
            if (b23Status <= 4)
            {
                b23Status++;
            }
            else
            {
                b23Status = 0;
            }
            b23.Text = b23Status.ToString();
        }
        private void b24_Click(object sender, EventArgs e)
        {
            if (b24Status <= 4)
            {
                b24Status++;
            }
            else
            {
                b24Status = 0;
            }
            b24.Text = b24Status.ToString();
        }
        private void b25_Click(object sender, EventArgs e)
        {
            if (b25Status <= 4)
            {
                b25Status++;
            }
            else
            {
                b25Status = 0;
            }
            b25.Text = b25Status.ToString();
        }
        private void b26_Click(object sender, EventArgs e)
        {
            if (b26Status <= 4)
            {
                b26Status++;
            }
            else
            {
                b26Status = 0;
            }
            b26.Text = b26Status.ToString();
        }
        private void b27_Click(object sender, EventArgs e)
        {
            if (b27Status <= 4)
            {
                b27Status++;
            }
            else
            {
                b27Status = 0;
            }
            b27.Text = b27Status.ToString();
        }
        private void b28_Click(object sender, EventArgs e)
        {
            if (b28Status <= 4)
            {
                b28Status++;
            }
            else
            {
                b28Status = 0;
            }
            b28.Text = b28Status.ToString();
        }
        private void b29_Click(object sender, EventArgs e)
        {
            if (b29Status <= 4)
            {
                b29Status++;
            }
            else
            {
                b29Status = 0;
            }
            b29.Text = b29Status.ToString();
        }
        private void b30_Click(object sender, EventArgs e)
        {
            if (b30Status <= 4)
            {
                b30Status++;
            }
            else
            {
                b30Status = 0;
            }
            b30.Text = b30Status.ToString();
        }
        private void b31_Click(object sender, EventArgs e)
        {
            if (b31Status <= 4)
            {
                b31Status++;
            }
            else
            {
                b31Status = 0;
            }
            b31.Text = b31Status.ToString();
        }
        private void b32_Click(object sender, EventArgs e)
        {
            if (b32Status <= 4)
            {
                b32Status++;
            }
            else
            {
                b32Status = 0;
            }
            b32.Text = b32Status.ToString();
        }
        private void b33_Click(object sender, EventArgs e)
        {
            if (b33Status <= 4)
            {
                b33Status++;
            }
            else
            {
                b33Status = 0;
            }
            b33.Text = b33Status.ToString();
        }
        private void b34_Click(object sender, EventArgs e)
        {
            if (b34Status <= 4)
            {
                b34Status++;
            }
            else
            {
                b34Status = 0;
            }
            b34.Text = b34Status.ToString();
        }
        private void b35_Click(object sender, EventArgs e)
        {
            if (b35Status <= 4)
            {
                b35Status++;
            }
            else
            {
                b35Status = 0;
            }
            b35.Text = b35Status.ToString();
        }
        private void b36_Click(object sender, EventArgs e)
        {
            if (b36Status <= 4)
            {
                b36Status++;
            }
            else
            {
                b36Status = 0;
            }
            b36.Text = b36Status.ToString();
        }
        private void b37_Click(object sender, EventArgs e)
        {
            if (b37Status <= 4)
            {
                b37Status++;
            }
            else
            {
                b37Status = 0;
            }
            b37.Text = b37Status.ToString();
        }
        private void b38_Click(object sender, EventArgs e)
        {
            if (b38Status <= 4)
            {
                b38Status++;
            }
            else
            {
                b38Status = 0;
            }
            b38.Text = b38Status.ToString();
        }
        private void b39_Click(object sender, EventArgs e)
        {
            if (b39Status <= 4)
            {
                b39Status++;
            }
            else
            {
                b39Status = 0;
            }
            b39.Text = b39Status.ToString();
        }
        private void b40_Click(object sender, EventArgs e)
        {
            if (b40Status <= 4)
            {
                b40Status++;
            }
            else
            {
                b40Status = 0;
            }
            b40.Text = b40Status.ToString();
        }
        private void b41_Click(object sender, EventArgs e)
        {
            if (b41Status <= 4)
            {
                b41Status++;
            }
            else
            {
                b41Status = 0;
            }
            b41.Text = b41Status.ToString();
        }
        private void b42_Click(object sender, EventArgs e)
        {
            if (b42Status <= 4)
            {
                b42Status++;
            }
            else
            {
                b42Status = 0;
            }
            b42.Text = b42Status.ToString();
        }
        private void b43_Click(object sender, EventArgs e)
        {
            if (b43Status <= 4)
            {
                b43Status++;
            }
            else
            {
                b43Status = 0;
            }
            b43.Text = b43Status.ToString();
        }
        private void b44_Click(object sender, EventArgs e)
        {
            if (b44Status <= 4)
            {
                b44Status++;
            }
            else
            {
                b44Status = 0;
            }
            b44.Text = b44Status.ToString();
        }
        private void b45_Click(object sender, EventArgs e)
        {
            if (b45Status <= 4)
            {
                b45Status++;
            }
            else
            {
                b45Status = 0;
            }
            b45.Text = b45Status.ToString();
        }
        private void b46_Click(object sender, EventArgs e)
        {
            if (b46Status <= 4)
            {
                b46Status++;
            }
            else
            {
                b46Status = 0;
            }
            b46.Text = b46Status.ToString();
        }
        private void b47_Click(object sender, EventArgs e)
        {
            if (b47Status <= 4)
            {
                b47Status++;
            }
            else
            {
                b47Status = 0;
            }
            b47.Text = b47Status.ToString();
        }
        private void b48_Click(object sender, EventArgs e)
        {
            if (b48Status <= 4)
            {
                b48Status++;
            }
            else
            {
                b48Status = 0;
            }
            b48.Text = b48Status.ToString();
        }
        private void b49_Click(object sender, EventArgs e)
        {
            if (b49Status <= 4)
            {
                b49Status++;
            }
            else
            {
                b49Status = 0;
            }
            b49.Text = b49Status.ToString();
        }
        private void b50_Click(object sender, EventArgs e)
        {
            if (b50Status <= 4)
            {
                b50Status++;
            }
            else
            {
                b50Status = 0;
            }
            b50.Text = b50Status.ToString();
        }
        private void b51_Click(object sender, EventArgs e)
        {
            if (b51Status <= 4)
            {
                b51Status++;
            }
            else
            {
                b51Status = 0;
            }
            b51.Text = b51Status.ToString();
        }
        private void b52_Click(object sender, EventArgs e)
        {
            if (b52Status <= 4)
            {
                b52Status++;
            }
            else
            {
                b52Status = 0;
            }
            b52.Text = b52Status.ToString();
        }
        private void b53_Click(object sender, EventArgs e)
        {
            if (b53Status <= 4)
            {
                b53Status++;
            }
            else
            {
                b53Status = 0;
            }
            b53.Text = b53Status.ToString();
        }
        private void b54_Click(object sender, EventArgs e)
        {
            if (b54Status <= 4)
            {
                b54Status++;
            }
            else
            {
                b54Status = 0;
            }
            b54.Text = b54Status.ToString();
        }
        private void b55_Click(object sender, EventArgs e)
        {
            if (b55Status <= 4)
            {
                b55Status++;
            }
            else
            {
                b55Status = 0;
            }
            b55.Text = b55Status.ToString();
        }
        private void b56_Click(object sender, EventArgs e)
        {
            if (b56Status <= 4)
            {
                b56Status++;
            }
            else
            {
                b56Status = 0;
            }
            b56.Text = b56Status.ToString();
        }
        private void b57_Click(object sender, EventArgs e)
        {
            if (b57Status <= 4)
            {
                b57Status++;
            }
            else
            {
                b57Status = 0;
            }
            b57.Text = b57Status.ToString();
        }
        private void b58_Click(object sender, EventArgs e)
        {
            if (b58Status <= 4)
            {
                b58Status++;
            }
            else
            {
                b58Status = 0;
            }
            b58.Text = b58Status.ToString();
        }
        private void b59_Click(object sender, EventArgs e)
        {
            if (b59Status <= 4)
            {
                b59Status++;
            }
            else
            {
                b59Status = 0;
            }
            b59.Text = b59Status.ToString();
        }
        private void b60_Click(object sender, EventArgs e)
        {
            if (b60Status <= 4)
            {
                b60Status++;
            }
            else
            {
                b60Status = 0;
            }
            b60.Text = b60Status.ToString();
        }
        private void b61_Click(object sender, EventArgs e)
        {
            if (b61Status <= 4)
            {
                b61Status++;
            }
            else
            {
                b61Status = 0;
            }
            b61.Text = b61Status.ToString();
        }
        private void b62_Click(object sender, EventArgs e)
        {
            if (b62Status <= 4)
            {
                b62Status++;
            }
            else
            {
                b62Status = 0;
            }
            b62.Text = b62Status.ToString();
        }
        private void b63_Click(object sender, EventArgs e)
        {
            if (b63Status <= 4)
            {
                b63Status++;
            }
            else
            {
                b63Status = 0;
            }
            b63.Text = b63Status.ToString();
        }
        private void b64_Click(object sender, EventArgs e)
        {
            if (b64Status <= 4)
            {
                b64Status++;
            }
            else
            {
                b64Status = 0;
            }
            b64.Text = b64Status.ToString();
        }

        private void save()
        {
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FileName = "level.json";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string fileName = saveFileDialog1.FileName;

            int[] statuses = new int[] {
                b1Status, b2Status, b3Status, b4Status, b5Status, b6Status, b7Status, b8Status,
                b9Status, b10Status, b11Status, b12Status, b13Status, b14Status, b15Status, b16Status,
                b17Status, b18Status, b19Status, b20Status, b21Status, b22Status, b23Status, b24Status,
                b25Status, b26Status, b27Status, b28Status, b29Status, b30Status, b31Status, b32Status,
                b33Status, b34Status, b35Status, b36Status, b37Status, b38Status, b39Status, b40Status,
                b41Status, b42Status, b43Status, b44Status, b45Status, b46Status, b47Status, b48Status,
                b49Status, b50Status, b51Status, b52Status, b53Status, b54Status, b55Status, b56Status,
                b57Status, b58Status, b59Status, b60Status, b61Status, b62Status, b63Status, b64Status
            };

            var rows = new System.Collections.Generic.List<int[]>();
            for (int r = 0; r < 8; r++)
            {
                int[] row = new int[8];
                for (int c = 0; c < 8; c++)
                    row[c] = statuses[r * 8 + c];
                rows.Add(row);
            }

            string json = System.Text.Json.JsonSerializer.Serialize(rows, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(fileName, json);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void load()
        {
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string fileName = openFileDialog1.FileName;
            string json = System.IO.File.ReadAllText(fileName);

            try
            {
                var rows = System.Text.Json.JsonSerializer.Deserialize<int[][]>(json);
                if (rows == null || rows.Length != 8 || System.Array.Exists(rows, r => r == null || r.Length != 8))
                {
                    MessageBox.Show("Invalid level file format.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int[] statuses = new int[64];
                for (int r = 0; r < 8; r++)
                {
                    for (int c = 0; c < 8; c++)
                    {
                        statuses[r * 8 + c] = rows[r][c];
                    }
                }

                // Assign to fields
                b1Status = statuses[0]; b2Status = statuses[1]; b3Status = statuses[2]; b4Status = statuses[3];
                b5Status = statuses[4]; b6Status = statuses[5]; b7Status = statuses[6]; b8Status = statuses[7];
                b9Status = statuses[8]; b10Status = statuses[9]; b11Status = statuses[10]; b12Status = statuses[11];
                b13Status = statuses[12]; b14Status = statuses[13]; b15Status = statuses[14]; b16Status = statuses[15];
                b17Status = statuses[16]; b18Status = statuses[17]; b19Status = statuses[18]; b20Status = statuses[19];
                b21Status = statuses[20]; b22Status = statuses[21]; b23Status = statuses[22]; b24Status = statuses[23];
                b25Status = statuses[24]; b26Status = statuses[25]; b27Status = statuses[26]; b28Status = statuses[27];
                b29Status = statuses[28]; b30Status = statuses[29]; b31Status = statuses[30]; b32Status = statuses[31];
                b33Status = statuses[32]; b34Status = statuses[33]; b35Status = statuses[34]; b36Status = statuses[35];
                b37Status = statuses[36]; b38Status = statuses[37]; b39Status = statuses[38]; b40Status = statuses[39];
                b41Status = statuses[40]; b42Status = statuses[41]; b43Status = statuses[42]; b44Status = statuses[43];
                b45Status = statuses[44]; b46Status = statuses[45]; b47Status = statuses[46]; b48Status = statuses[47];
                b49Status = statuses[48]; b50Status = statuses[49]; b51Status = statuses[50]; b52Status = statuses[51];
                b53Status = statuses[52]; b54Status = statuses[53]; b55Status = statuses[54]; b56Status = statuses[55];
                b57Status = statuses[56]; b58Status = statuses[57]; b59Status = statuses[58]; b60Status = statuses[59];
                b61Status = statuses[60]; b62Status = statuses[61]; b63Status = statuses[62]; b64Status = statuses[63];

                // Update button labels to reflect loaded values
                b1.Text = b1Status.ToString(); b2.Text = b2Status.ToString(); b3.Text = b3Status.ToString(); b4.Text = b4Status.ToString();
                b5.Text = b5Status.ToString(); b6.Text = b6Status.ToString(); b7.Text = b7Status.ToString(); b8.Text = b8Status.ToString();
                b9.Text = b9Status.ToString(); b10.Text = b10Status.ToString(); b11.Text = b11Status.ToString(); b12.Text = b12Status.ToString();
                b13.Text = b13Status.ToString(); b14.Text = b14Status.ToString(); b15.Text = b15Status.ToString(); b16.Text = b16Status.ToString();
                b17.Text = b17Status.ToString(); b18.Text = b18Status.ToString(); b19.Text = b19Status.ToString(); b20.Text = b20Status.ToString();
                b21.Text = b21Status.ToString(); b22.Text = b22Status.ToString(); b23.Text = b23Status.ToString(); b24.Text = b24Status.ToString();
                b25.Text = b25Status.ToString(); b26.Text = b26Status.ToString(); b27.Text = b27Status.ToString(); b28.Text = b28Status.ToString();
                b29.Text = b29Status.ToString(); b30.Text = b30Status.ToString(); b31.Text = b31Status.ToString(); b32.Text = b32Status.ToString();
                b33.Text = b33Status.ToString(); b34.Text = b34Status.ToString(); b35.Text = b35Status.ToString(); b36.Text = b36Status.ToString();
                b37.Text = b37Status.ToString(); b38.Text = b38Status.ToString(); b39.Text = b39Status.ToString(); b40.Text = b40Status.ToString();
                b41.Text = b41Status.ToString(); b42.Text = b42Status.ToString(); b43.Text = b43Status.ToString(); b44.Text = b44Status.ToString();
                b45.Text = b45Status.ToString(); b46.Text = b46Status.ToString(); b47.Text = b47Status.ToString(); b48.Text = b48Status.ToString();
                b49.Text = b49Status.ToString(); b50.Text = b50Status.ToString(); b51.Text = b51Status.ToString(); b52.Text = b52Status.ToString();
                b53.Text = b53Status.ToString(); b54.Text = b54Status.ToString(); b55.Text = b55Status.ToString(); b56.Text = b56Status.ToString();
                b57.Text = b57Status.ToString(); b58.Text = b58Status.ToString(); b59.Text = b59Status.ToString(); b60.Text = b60Status.ToString();
                b61.Text = b61Status.ToString(); b62.Text = b62Status.ToString(); b63.Text = b63Status.ToString(); b64.Text = b64Status.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to load file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string product = Application.ProductName;
            string version = Application.ProductVersion;
            string msg = $"{product}\nVersion: {version}\n\nCreated by landoodle123\nLicensed under the BSD license";
            MessageBox.Show(msg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
