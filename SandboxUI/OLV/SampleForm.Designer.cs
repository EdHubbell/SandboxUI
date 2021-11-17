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
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.olvColumnThing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
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
            this.objectListView.Size = new System.Drawing.Size(328, 357);
            this.objectListView.SmallImageList = this.imageListSmall;
            this.objectListView.TabIndex = 0;
            this.objectListView.UnfocusedSelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this.objectListView.UseCellFormatEvents = true;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView_FormatCell);
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
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.objectListView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.propertyGrid, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(669, 363);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(337, 3);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid.Size = new System.Drawing.Size(329, 357);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // olvColumnThing
            // 
            this.olvColumnThing.ImageAspectName = "ThingIcon";
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 363);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SampleForm";
            this.Text = "Sample Form";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
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
    }
}