﻿using System;
using System.Windows.Forms;

namespace OLV
{
    partial class SampleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleForm));
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnParameter = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnThing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblActiveParameter = new System.Windows.Forms.Label();
            this.ucOLVPropertyGrid1 = new OLV.ucOLVPropertyGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.objectListView.Size = new System.Drawing.Size(418, 357);
            this.objectListView.SmallImageList = this.imageListSmall;
            this.objectListView.TabIndex = 0;
            this.objectListView.UnfocusedSelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.objectListView.UseCellFormatEvents = true;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.ObjectListView_FormatCell);
            this.objectListView.SelectionChanged += new System.EventHandler(this.ObjectListView_SelectionChanged);
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
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "cycle");
            this.imageListSmall.Images.SetKeyName(1, "Double");
            this.imageListSmall.Images.SetKeyName(2, "Single");
            this.imageListSmall.Images.SetKeyName(3, "Triple");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "null");
            this.imageListLarge.Images.SetKeyName(1, "check");
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel.Controls.Add(this.objectListView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelGrid, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(424, 363);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanelGrid
            // 
            this.tableLayoutPanelGrid.ColumnCount = 1;
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Controls.Add(this.propertyGrid, 0, 1);
            this.tableLayoutPanelGrid.Controls.Add(this.btnApply, 0, 2);
            this.tableLayoutPanelGrid.Controls.Add(this.lblActiveParameter, 0, 0);
            this.tableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrid.Location = new System.Drawing.Point(427, 3);
            this.tableLayoutPanelGrid.Name = "tableLayoutPanelGrid";
            this.tableLayoutPanelGrid.RowCount = 3;
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGrid.Size = new System.Drawing.Size(1, 357);
            this.tableLayoutPanelGrid.TabIndex = 2;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid.Size = new System.Drawing.Size(1, 320);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid_PropertyValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(3, 329);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(1, 25);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblActiveParameter
            // 
            this.lblActiveParameter.AutoSize = true;
            this.lblActiveParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveParameter.Location = new System.Drawing.Point(3, 0);
            this.lblActiveParameter.Name = "lblActiveParameter";
            this.lblActiveParameter.Size = new System.Drawing.Size(1, 1);
            this.lblActiveParameter.TabIndex = 3;
            this.lblActiveParameter.Text = "label1";
            this.lblActiveParameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucOLVPropertyGrid1
            // 
            this.ucOLVPropertyGrid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucOLVPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOLVPropertyGrid1.Location = new System.Drawing.Point(521, 3);
            this.ucOLVPropertyGrid1.Name = "ucOLVPropertyGrid1";
            this.ucOLVPropertyGrid1.Size = new System.Drawing.Size(512, 526);
            this.ucOLVPropertyGrid1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucOLVPropertyGrid1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 532);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Form";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelGrid.ResumeLayout(false);
            this.tableLayoutPanelGrid.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnParameter;
        private System.Windows.Forms.ImageList imageListLarge;
        private BrightIdeasSoftware.OLVColumn olvColumnFrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ImageList imageListSmall;
        private BrightIdeasSoftware.OLVColumn olvColumnThing;
        private TableLayoutPanel tableLayoutPanelGrid;
        private Button btnApply;
        private Label lblActiveParameter;
        private ucOLVPropertyGrid ucOLVPropertyGrid1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}