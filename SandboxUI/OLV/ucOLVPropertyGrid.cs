using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
            //this.Dock = DockStyle.Fill;
            //tlpMain.Dock = DockStyle.Fill;
            InitializeModel();
            InitializeObjectListView();
            propertyGrid.BrowsableAttributes = new AttributeCollection(new CategoryAttribute("User Parameters"));

            this.DoubleBuffered = true;

            if (tlpMain.Width != this.Width * 2) tlpMain.Width = this.Width * 2;

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
            objectListView.SetObjects(Parameters);
            objectListView.SmallImageList = imageListSmall;

            SlidePanes(true);
        }





        private void objectListView_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
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


        private async void objectListView_SelectionChanged(object sender, EventArgs e)
        {
            if (PreventSwap)
            {
                PreventSwap = false;
                return;
            }

            lblActiveParameter.Text = ((Parameter)objectListView.SelectedObject).ParameterName;
            lblActiveParameterDesc.Text = ((Parameter)objectListView.SelectedObject).Description;


            propertyGrid.SelectedObject = objectListView.SelectedObject;
            SelectedIndex = objectListView.SelectedIndex;
            SlidePanes(false);

        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            objectListView.SetObjects(Parameters);
            objectListView.SelectedIndex = SelectedIndex;
            btnApply.BackColor = btnApply.FlatAppearance.MouseOverBackColor;
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            SlidePanes(true);
            PreventSwap = true;
            objectListView.DeselectAll();
        }

        private async Task SlidePanes(bool showOLV)
        {
            this.Cursor = Cursors.WaitCursor;

            // Set the width of the main table layout panel to be 2x the width of the control. 
            // This allows us to move that tlp in the background.
            // There's an assumption here that each column is 50% of the total width of the
            // tlpMain object. So by making the tlpMain object 2x as wide as the control, the 
            // tlpMain is exactly the right size to show one or the other of its columns.
            if (tlpMain.Width != this.Width * 2) tlpMain.Width = this.Width * 2;

            // To see column 0, set Location.X to 0. To see column 1, set Location.X to a negative value equal to the width of column 0.
            int targetX = showOLV ? 0 : this.Width * -1;

            try
            {
                // Determines the increment by which X will be changed. Width/10 means the tlpMain position 
                // will be changed 10x as we slide. 
                int increment = (showOLV ? this.Width / 10 : -1 * this.Width / 10);

                // Slide tlpMain to the left or right. 
                if (tlpMain.Location.X > targetX)
                {
                    while (tlpMain.Location.X > targetX)
                    {
                        await Task.Delay(1);
                        tlpMain.Location = new Point(tlpMain.Location.X + increment, 0);
                    }
                }
                else
                {
                    while (tlpMain.Location.X < targetX)
                    {
                        await Task.Delay(1);
                        tlpMain.Location = new Point(tlpMain.Location.X + increment, 0);
                    }
                }

            }
            catch (Exception ex)
            {
                // Do nothing. Animation math errors aren't something we want to crash the app for. 
            }

            // Set the final position of tlpMain.
            tlpMain.Location = new Point(targetX, 0);

            this.Cursor = Cursors.Default;
        }

        private void ucOLVPropertyGrid_Resize(object sender, EventArgs e)
        {
            if (tlpMain.Width != this.Width * 2) tlpMain.Width = this.Width * 2;
            if (tlpMain.Height != this.Height) tlpMain.Height = this.Height;

        }
    }
}
