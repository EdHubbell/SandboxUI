
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
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnParameter = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnThing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.lblActiveParameterDesc = new System.Windows.Forms.Label();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblActiveParameter = new System.Windows.Forms.Label();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
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
            this.tlpMain.Size = new System.Drawing.Size(423, 322);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Controls.Add(this.objectListView, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 1;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(205, 316);
            this.tlpLeft.TabIndex = 3;
            // 
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.olvColumnParameter);
            this.objectListView.AllColumns.Add(this.olvColumnFrequency);
            this.objectListView.AllColumns.Add(this.olvColumnThing);
            this.objectListView.CellEditUseWholeCell = false;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnParameter,
            this.olvColumnFrequency,
            this.olvColumnThing});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView.FullRowSelect = true;
            this.objectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView.HeaderUsesThemes = true;
            this.objectListView.HideSelection = false;
            this.objectListView.Location = new System.Drawing.Point(3, 3);
            this.objectListView.Name = "objectListView";
            this.objectListView.RowHeight = 48;
            this.objectListView.SelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.objectListView.ShowGroups = false;
            this.objectListView.ShowImagesOnSubItems = true;
            this.objectListView.Size = new System.Drawing.Size(199, 310);
            this.objectListView.TabIndex = 1;
            this.objectListView.UnfocusedSelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.objectListView.UseCellFormatEvents = true;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView_FormatCell);
            this.objectListView.SelectionChanged += new System.EventHandler(this.objectListView_SelectionChanged);
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
            this.tlpRight.Controls.Add(this.lblActiveParameterDesc, 0, 1);
            this.tlpRight.Controls.Add(this.propertyGrid, 0, 2);
            this.tlpRight.Controls.Add(this.btnApply, 0, 3);
            this.tlpRight.Controls.Add(this.lblActiveParameter, 0, 0);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(214, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 4;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.Size = new System.Drawing.Size(206, 316);
            this.tlpRight.TabIndex = 2;
            // 
            // lblActiveParameterDesc
            // 
            this.lblActiveParameterDesc.AutoSize = true;
            this.lblActiveParameterDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveParameterDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveParameterDesc.Location = new System.Drawing.Point(3, 30);
            this.lblActiveParameterDesc.Name = "lblActiveParameterDesc";
            this.lblActiveParameterDesc.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblActiveParameterDesc.Size = new System.Drawing.Size(200, 20);
            this.lblActiveParameterDesc.TabIndex = 3;
            this.lblActiveParameterDesc.Text = "ActiveParameterDesc";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(3, 53);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(200, 220);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(3, 279);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 34);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblActiveParameter
            // 
            this.lblActiveParameter.AutoSize = true;
            this.lblActiveParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveParameter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveParameter.Location = new System.Drawing.Point(3, 0);
            this.lblActiveParameter.Name = "lblActiveParameter";
            this.lblActiveParameter.Size = new System.Drawing.Size(200, 30);
            this.lblActiveParameter.TabIndex = 2;
            this.lblActiveParameter.Text = "ActiveParameter";
            this.lblActiveParameter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucOLVPropertyGrid";
            this.Size = new System.Drawing.Size(423, 322);
            this.Load += new System.EventHandler(this.ucOLVPropertyGrid_Load);
            this.Resize += new System.EventHandler(this.ucOLVPropertyGrid_Resize);
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnParameter;
        private BrightIdeasSoftware.OLVColumn olvColumnFrequency;
        private BrightIdeasSoftware.OLVColumn olvColumnThing;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Label lblActiveParameter;
        private System.Windows.Forms.Label lblActiveParameterDesc;
    }
}
