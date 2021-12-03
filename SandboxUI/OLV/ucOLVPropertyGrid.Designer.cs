
namespace OLV
{
    partial class ucOLVPropertyGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOLVPropertyGrid));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.olvLeft = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnParameter = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnThing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.pgRight = new System.Windows.Forms.PropertyGrid();
            this.btnApply = new System.Windows.Forms.Button();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLeft)).BeginInit();
            this.tlpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.tlpRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(321, 322);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Controls.Add(this.olvLeft, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 1;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(154, 316);
            this.tlpLeft.TabIndex = 3;
            // 
            // olvLeft
            // 
            this.olvLeft.AllColumns.Add(this.olvColumnParameter);
            this.olvLeft.AllColumns.Add(this.olvColumnFrequency);
            this.olvLeft.AllColumns.Add(this.olvColumnThing);
            this.olvLeft.CellEditUseWholeCell = false;
            this.olvLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnParameter,
            this.olvColumnFrequency,
            this.olvColumnThing});
            this.olvLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvLeft.FullRowSelect = true;
            this.olvLeft.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvLeft.HeaderUsesThemes = true;
            this.olvLeft.HideSelection = false;
            this.olvLeft.Location = new System.Drawing.Point(3, 3);
            this.olvLeft.Name = "olvLeft";
            this.olvLeft.RowHeight = 48;
            this.olvLeft.SelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.olvLeft.ShowGroups = false;
            this.olvLeft.ShowImagesOnSubItems = true;
            this.olvLeft.Size = new System.Drawing.Size(148, 310);
            this.olvLeft.TabIndex = 1;
            this.olvLeft.UnfocusedSelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.olvLeft.UseCellFormatEvents = true;
            this.olvLeft.UseCompatibleStateImageBehavior = false;
            this.olvLeft.View = System.Windows.Forms.View.Details;
            this.olvLeft.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvLeft_FormatCell);
            this.olvLeft.SelectionChanged += new System.EventHandler(this.olvLeft_SelectionChanged);
            // 
            // olvColumnParameter
            // 
            this.olvColumnParameter.AspectName = "ParameterName";
            this.olvColumnParameter.FillsFreeSpace = true;
            this.olvColumnParameter.ImageAspectName = "ParameterIcon";
            this.olvColumnParameter.Text = "Parameter";
            // 
            // olvColumnFrequency
            // 
            this.olvColumnFrequency.AspectName = "FrequencyString";
            this.olvColumnFrequency.AspectToStringFormat = "";
            this.olvColumnFrequency.ImageAspectName = "FrequencyIcon";
            // 
            // olvColumnThing
            // 
            this.olvColumnThing.ImageAspectName = "ThingIcon";
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.pgRight, 0, 0);
            this.tlpRight.Controls.Add(this.btnApply, 0, 1);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(163, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 2;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRight.Size = new System.Drawing.Size(155, 316);
            this.tlpRight.TabIndex = 2;
            // 
            // pgRight
            // 
            this.pgRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgRight.Location = new System.Drawing.Point(3, 3);
            this.pgRight.Name = "pgRight";
            this.pgRight.Size = new System.Drawing.Size(149, 270);
            this.pgRight.TabIndex = 0;
            this.pgRight.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgRight_PropertyValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(3, 279);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(149, 34);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "null");
            this.imageListLarge.Images.SetKeyName(1, "check");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "cycle");
            this.imageListSmall.Images.SetKeyName(1, "Double");
            this.imageListSmall.Images.SetKeyName(2, "Single");
            this.imageListSmall.Images.SetKeyName(3, "Triple");
            // 
            // ucOLVPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.DoubleBuffered = true;
            this.Name = "ucOLVPropertyGrid";
            this.Size = new System.Drawing.Size(321, 322);
            this.Load += new System.EventHandler(this.ucOLVPropertyGrid_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvLeft)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private BrightIdeasSoftware.ObjectListView olvLeft;
        private BrightIdeasSoftware.OLVColumn olvColumnParameter;
        private BrightIdeasSoftware.OLVColumn olvColumnFrequency;
        private BrightIdeasSoftware.OLVColumn olvColumnThing;
        private System.Windows.Forms.PropertyGrid pgRight;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}
