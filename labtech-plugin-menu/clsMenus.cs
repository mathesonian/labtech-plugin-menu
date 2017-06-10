using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using LabTech.Interfaces;

namespace labtech_plugin_menu
{
    /// <summary>
    /// Class that implements the IMenu interface to add Menu Items to the Main, Tools, and View Menus.
    /// </summary>
    /// <seealso cref="LabTech.Interfaces.IMenu" />
    public class clsMenus : IMenu
    {
        /// <summary>
        /// The IControlCenter object.
        /// </summary>
        private IControlCenter objHost;
        /// <summary>
        /// Instance of the ToolsForm Window.
        /// </summary>
        private ToolsForm toolsForm;

        /// <summary>
        /// Gets the string name of the menu class.
        /// </summary>
        /// <value>
        /// The name string.
        /// </value>
        public string Name
        {
            get
            {
                return "labtech-plugin-menu";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="clsMenus"/> class.
        /// </summary>
        public clsMenus()
        {

        }

        /// <summary>
        /// Called when the Control Center is opened.
        /// </summary>
        /// <param name="objHost">The IControlCenter object.</param>
        public void Initialize(IControlCenter objHost)
        {
            this.objHost = objHost;
        }

        /// <summary>
        /// Called when the Control Center is closed.
        /// </summary>
        public void Decommision()
        {
            this.objHost = (IControlCenter)null;
        }

        /// <summary>
        /// Adds MenuItems to the Main Menu by returning an array of MenuItems.
        /// </summary>
        /// <returns>
        /// The MenuItem array to be added to the Main Menu.
        /// </returns>
        public MenuItem[] CreateMainMenu()
        {
            return (MenuItem[])null;
        }

        /// <summary>
        /// Adds MenuItems to the Tools Menu by returning an array of MenuItems.
        /// </summary>
        /// <returns>
        /// The MenuItem array to be added to the Tools Menu.
        /// </returns>
        public MenuItem[] CreateToolsMenu()
        {
            MenuItem[] menuItems = new MenuItem[1];
            MenuItem menuItem = new MenuItem("Labtech Example Menu", new EventHandler(this.ShowToolsForm));
            menuItems[0] = menuItem;

            return menuItems;
        }

        /// <summary>
        /// Adds MenuItems to the View Menu by returning an array of MenuItems.
        /// </summary>
        /// <returns>
        /// The MenuItem array to be added to the View Menu.
        /// </returns>
        public MenuItem[] CreateViewMenu()
        {
            return (MenuItem[])null;
        }

        /// <summary>
        /// Displays the ToolsForm.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void ShowToolsForm(object sender, EventArgs e)
        {
            if ((this.toolsForm == null) || (this.toolsForm.IsDisposed))
            {
                this.toolsForm = new ToolsForm(this.objHost);
                this.toolsForm.Show();
            }
            else
            {
                this.toolsForm.BringToFront();
            }
        }
    }
}
