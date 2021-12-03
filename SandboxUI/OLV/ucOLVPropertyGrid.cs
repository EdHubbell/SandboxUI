using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLV
{
    public partial class ucOLVPropertyGrid : UserControl
    {
        private List<Parameter> Parameters;
        private int SelectedIndex = -1;
        private bool PreventSwap = false;


        public ucOLVPropertyGrid()
        {
            InitializeComponent();
        }

        private void ucOLVPropertyGrid_Load(object sender, EventArgs e)
        {
            // Note that Load happens from within Visual Studio, in design time. For example, if you throw this control on a form, it'll render on the form in Design View after this code is called. 
            // On the one hand, this can be pretty dangerous. Throw an exception in the Load event on a user control, and your whole Designer experience is f'd. 
            // On the other, it can be quite nice to see a rendered user control where it'll be, and have a different designer experience when editing that same user control.

            InitializeModel();
            InitializeObjectListView();
            pgRight.BrowsableAttributes = new AttributeCollection(new CategoryAttribute("User Parameters"));
        }



        private void InitializeModel()
        {
            Parameters = new List<Parameter>
            {
                new Parameter("Clean"),
                new Parameter("Simulation"),
                new Parameter("Source Align"),
                new Parameter("Pre-Print Metrology"),
                new Parameter("Target Align"),
                new Parameter("Post-Print Metrology"),
                new Parameter("Custom Start")
            };
        }


        public void InitializeObjectListView()
        {
            olvColumnParameter.AspectToStringConverter = delegate (object x) { return ""; };
            olvLeft.SetObjects(Parameters);
            SwapPanes(true);
        }





        private void olvLeft_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Parameter parameter = (Parameter)e.Model;
                NamedDescriptionDecoration decoration = new NamedDescriptionDecoration
                {
                    ImageList = imageListLarge,
                    Title = parameter.ParameterName,
                    ImageName = parameter.ParameterIcon,
                    Description = parameter.Description
                };
                e.SubItem.Decoration = decoration;
            }

        }


        private void olvLeft_SelectionChanged(object sender, EventArgs e)
        {
            if (PreventSwap)
            {
                PreventSwap = false;
                return;
            }
            //            lblActiveParameter.Text = ((Parameter)olvLeft.SelectedObject).ParameterName;
            pgRight.SelectedObject = olvLeft.SelectedObject;
            SelectedIndex = olvLeft.SelectedIndex;
            SwapPanes(false);

        }

        private void pgRight_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            olvLeft.SetObjects(Parameters);
            olvLeft.SelectedIndex = SelectedIndex;
            btnApply.BackColor = btnApply.FlatAppearance.MouseOverBackColor;
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            SwapPanes(true);
            PreventSwap = true;
            olvLeft.DeselectAll();
        }

        private async Task SwapPanes(bool showOLV)
        {
            int indexToShow = showOLV ? 0 : 1;
            int indexToHide = showOLV ? 1 : 0;

            while (tlpMain.ColumnStyles[indexToHide].Width > 0)
            {
                tlpMain.SuspendLayout();
                tlpMain.ColumnStyles[indexToHide].Width -= 25;
                tlpMain.ColumnStyles[indexToShow].Width += 25;
                tlpMain.ResumeLayout();
            }

            tlpMain.SuspendLayout();
            tlpMain.ColumnStyles[indexToHide].Width = 0;
            tlpMain.ColumnStyles[indexToShow].Width = 100;
            tlpMain.ResumeLayout();
        }

    }
}
