using System;
using System.Web.UI;

/// <summary>
/// This is the code-behind file for the Contact page
/// </summary>
/// <author>
/// Kathryn Browning
/// </author>
/// <version>
/// February 3, 2015
/// </version>
public partial class Request : Page
{
    private int _sessionClicks;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Replace this comment with code to pull the data out of the
        //  Session object and pass it to DisplayReservation
        if (IsPostBack || (Request.Cookies["FirstName"] == null || Request.Cookies["LastName"] == null))
        {
            return;
        }
        this.txtFirstName.Text = Request.Cookies["FirstName"].Value;
        this.txtLastName.Text = Request.Cookies["LastName"].Value;

        if (Session["Count"] == null)
        {
            this._sessionClicks = 0;
        }
        else
        {
            this._sessionClicks = Convert.ToInt32(Session["Count"]);
        }

        this.lblMessage.Text = "It took you " + this._sessionClicks.ToString() + " clicks on Submit<br />" +
                               "Thank you for your request.<br />We will gte back to you within 24 hours";

  }

    /// <summary>
    /// Displays the reservation.
    /// </summary>
    private void DisplayReservation()
    {
        // Replace this comment with the appropriate code to load
        //  the data out of the object and onto the page

        Session["FirstName"] = this.txtFirstName;
        Session["LastName"] = this.txtLastName;
        Session["Email"] = this.txtEmail;
        Session["Phone"] = this.txtPhone;

    }

    /// <summary>
    /// Handles the Click event of the btnClear control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtFirstName.Text = "";
        this.txtLastName.Text = "";
        this.txtEmail.Text = "";
        this.txtPhone.Text = "";
        this.ddlPreferredMethod.SelectedIndex = 0;
        this.lblMessage.Text = "";
    }

    /// <summary>
    /// Handles the Click event of the btnSubmit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }

        this._sessionClicks++;
        this.lblMessage.Text = this.lblMessage.Text = "It took you " + this._sessionClicks.ToString() +
            " clicks on Submit<br />Thank you for your request.<br />We will gte back to you within 24 hours";
        Session["Count"] = this._sessionClicks;
    }
}