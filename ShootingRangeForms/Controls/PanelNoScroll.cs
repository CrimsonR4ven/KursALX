namespace ShootingRangeForms.Controls
{
    class PanelNoScroll : Panel
    {
        protected override System.Drawing.Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;
        }
    }
}
