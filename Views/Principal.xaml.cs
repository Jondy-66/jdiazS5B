namespace jdiazS5B.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        App.personRepo.AddNewPerson(txt_Name.Text);
        lblStatus.Text = App.personRepo.status;

    }

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
        List<Persona> people = App.personRepo.GetALLPeople();
        listapersonas.ItemSource = people;
    }
}