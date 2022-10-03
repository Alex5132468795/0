namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
	[QueryProperty(nameof(STR),"input")]
    public string STR
    {
        set
        {
            Label.Text = value;
        }
    }
    public NewPage1()
	{	
		InitializeComponent();
	}
}