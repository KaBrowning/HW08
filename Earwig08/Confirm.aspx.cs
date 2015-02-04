using System;
using System.Web;
using System.Web.UI;

/// <summary>
/// This is the code-behind file for the Confirmation page
/// </summary>
/// <author>
/// Replace this text with your first and last name
/// </author>
/// <version>
/// Replace this text with today's date
/// </version>
public partial class Confirm : Page
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
    }

    /// <summary>
    /// Handles the Click event of the btnConfirm control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }

        this._sessionClicks++;
        this.lblMessage.Text = this.lblMessage.Text = "It took you " + this._sessionClicks.ToString() + 
            " clicks on Submit<br />Thank you for your request.<br />We will gte back to you within 24 hours";
        Session["Count"] = this._sessionClicks;

        var firstNameCookie = new HttpCookie("FirstName", this.lblFirstName.Text);
        firstNameCookie.Expires = DateTime.Now.AddMinutes(10);
        Response.Cookies.Add(firstNameCookie);

        var lastNameCookie = new HttpCookie("LastName", this.lblLastName.Text);
        lastNameCookie.Expires = DateTime.Now.AddMinutes(10);
        Response.Cookies.Add(lastNameCookie);
    }
}