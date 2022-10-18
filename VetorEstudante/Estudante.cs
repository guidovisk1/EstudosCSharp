

namespace VetorEstudante
{
    public class Estudante
    {
        string nome { get; set; }
        string email { get; set; }


        public Estudante(string Nome, string Email)
        {
            nome = Nome;
            email = Email;
        }

        public override string ToString()
        {
            return nome + ", " + email;
        }
    }
}
