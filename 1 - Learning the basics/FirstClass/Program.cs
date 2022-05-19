namespace FirstModule
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //[PT]Escreve uma linha com o conteudo entre haspas no console
            //[EN] Write a line with the content between the quotes.
        }

        void intTypes()
        {

            byte bt1; // 8 Bits from 0 to 255
            sbyte bt2; // 8 Bits from -128 to 127

            //This part o variables are represented from variables that have a negative signal, and their unsigned peers. 

            //With negatives
            short sh1; // 16-bit from -32.768 to 32.767
            int in1;   // 32-bit from -2.147.483.648 to 2.147.483.647
            long lo1;  // 64-bit from -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807

            //Without negatives
            ushort sh2;// 16-bit from 0 to 65.535
            uint in2;  // 32-bit from 0 to 4.294.967.295
            ulong lo2;     // 64-bit from 0 to 18.446.744.073.709.551.615

        }

        void floatingTypes()
        {
            //Floating point VARIABLES
            float fl; // 32bits to use you need to especify the F notation like 2.500f
            double db; //64bits don't need a notation
            decimal dc; //128bits to use you need to especify the M notation like 2.500m
        }


        void boolType()
        {

            bool userStatus = false; // 

        }

        void textType()
        {
            //Characteres
            //Working with unicode
            // We can't use double quotes in this case, we need to use single quotes

            char firstLetter = 'A';
            var secondLetter = 'B';

            //Char array

            string text = "Text test a@!.";


        }

    void nullableType(){
        //NULL types
        //when you need to permit a null type the right declaration is (var? = {value}) ex:
        int notNullIdade = 0;
        int? idade = 0;

        idade = null;
        //notNullIdade = null; 
        //if you uncomment, we can see a error. Because a normal int can't be nullable
    }

    }

    class Aluno
    {
        string nome;
        int idade;
        string nomeMãe;

        string getNome()
        {
            return nome;
        }
        int getIdade()
        {
            return idade;
        }
        string getnomeMãe()
        {
            return nomeMãe;
        }

        void setNome(string nome)
        {
            this.nome = nome;
        }

        void setIdade(int idade)
        {
            this.idade = idade;
        }
        void setNomeMãe(string nomeMãe)
        {
            this.nomeMãe = nomeMãe;
        }
    }

}