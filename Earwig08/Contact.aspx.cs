using System;

/// <summary>
/// This is the code-behind file for the Contact page
/// </summary>
/// <author>
/// Replace this text with your first and last name
/// </author>
/// <version>
/// Replace this text with today's date
/// </version>
public partial class Request : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        
        // Replace this comment with code to pull the data out of the
        //  Session object and pass it to DisplayReservation
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

}