using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demirog";
            kurs1.KursunIzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Berkay Bilgin";
            kurs2.KursunIzlenmeOranı = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.KursunEgitmeni = "Kerem";
            kurs3.KursunIzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Unity";
            kurs4.KursunEgitmeni = "Onur";
            kurs4.KursunIzlenmeOranı = 89;

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursunEgitmeni);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};
            foreach (Kurs course in kurslar)
            {
                Console.WriteLine(course.KursAdi);
            }
        }




/*Type	Description	Range	Suffix
byte	8-bit unsigned integer	0 to 255	
sbyte	8-bit signed integer	-128 to 127	
short	16-bit signed integer	-32,768 to 32,767	
ushort	16-bit unsigned integer	0 to 65,535	
int	32-bit signed integer	-2,147,483,648
to
2,147,483,647	
uint	32-bit unsigned integer	0 to 4,294,967,295	u
long	64-bit signed integer	-9,223,372,036,854,775,808
to
9,223,372,036,854,775,807	l
ulong	64-bit unsigned integer	0 to 18,446,744,073,709,551,615	ul
float	32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38	f
double	64-bit double-precision floating point type	-1.79769313486232e308 to 1.79769313486232e308	d
decimal	128-bit decimal type for financial and monetary calculations	(+ or -)1.0 x 10e-28
to
7.9 x 10e28	m
char	16-bit single Unicode character	Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)	
bool	8-bit logical true/false value	True or False	
object	Base type of all other types.		
string	A sequence of Unicode characters		
DateTime	Represents date and time	0:00:00am 1/1/01
to
11:59:59pm 12/31/999*/

    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int KursunIzlenmeOranı { get; set; }
    }
}
