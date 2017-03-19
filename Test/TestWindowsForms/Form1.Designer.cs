namespace TestWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_plz = new System.Windows.Forms.TextBox();
            this.textBox_personen = new System.Windows.Forms.TextBox();
            this.textBox_volumen = new System.Windows.Forms.TextBox();
            this.textBox_straße = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_personen = new System.Windows.Forms.Label();
            this.label_plz = new System.Windows.Forms.Label();
            this.label_straße = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_plz);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_personen);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_volumen);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_straße);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label_personen);
            this.splitContainer1.Panel1.Controls.Add(this.label_plz);
            this.splitContainer1.Panel1.Controls.Add(this.label_straße);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gmap);
            this.splitContainer1.Size = new System.Drawing.Size(898, 584);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rezlets Drive";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(94, 353);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 32);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_plz
            // 
            this.textBox_plz.Location = new System.Drawing.Point(174, 192);
            this.textBox_plz.Name = "textBox_plz";
            this.textBox_plz.Size = new System.Drawing.Size(100, 20);
            this.textBox_plz.TabIndex = 7;
            // 
            // textBox_personen
            // 
            this.textBox_personen.Location = new System.Drawing.Point(174, 224);
            this.textBox_personen.Name = "textBox_personen";
            this.textBox_personen.Size = new System.Drawing.Size(100, 20);
            this.textBox_personen.TabIndex = 6;
            // 
            // textBox_volumen
            // 
            this.textBox_volumen.Location = new System.Drawing.Point(174, 250);
            this.textBox_volumen.Name = "textBox_volumen";
            this.textBox_volumen.Size = new System.Drawing.Size(100, 20);
            this.textBox_volumen.TabIndex = 5;
            // 
            // textBox_straße
            // 
            this.textBox_straße.Location = new System.Drawing.Point(174, 164);
            this.textBox_straße.Name = "textBox_straße";
            this.textBox_straße.Size = new System.Drawing.Size(100, 20);
            this.textBox_straße.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kofferraum Volumen";
            // 
            // label_personen
            // 
            this.label_personen.AutoSize = true;
            this.label_personen.Location = new System.Drawing.Point(43, 227);
            this.label_personen.Name = "label_personen";
            this.label_personen.Size = new System.Drawing.Size(83, 13);
            this.label_personen.TabIndex = 2;
            this.label_personen.Text = "Personenanzahl";
            // 
            // label_plz
            // 
            this.label_plz.AutoSize = true;
            this.label_plz.Location = new System.Drawing.Point(43, 195);
            this.label_plz.Name = "label_plz";
            this.label_plz.Size = new System.Drawing.Size(27, 13);
            this.label_plz.TabIndex = 1;
            this.label_plz.Text = "PLZ";
            // 
            // label_straße
            // 
            this.label_straße.AutoSize = true;
            this.label_straße.Location = new System.Drawing.Point(43, 167);
            this.label_straße.Name = "label_straße";
            this.label_straße.Size = new System.Drawing.Size(38, 13);
            this.label_straße.TabIndex = 0;
            this.label_straße.Text = "Straße";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(3, 3);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(589, 578);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 13D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 584);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_straße;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_plz;
        private System.Windows.Forms.TextBox textBox_personen;
        private System.Windows.Forms.TextBox textBox_volumen;
        private System.Windows.Forms.TextBox textBox_straße;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_personen;
        private System.Windows.Forms.Label label_plz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;

    }
}

