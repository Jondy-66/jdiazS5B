using jdiazS5B.Utils;

namespace jdiazS5B
{
    public partial class App : Application
    {
        public static PersonRepository personRepo;
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Views.Principal();
            personRepo = personRepository;
        }
    }
}
