using System;

namespace Covertir_de_numero_a_caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "n";  // este es el caracter clave para no detener el programa y seguir ejecutandolo.

            Console.WriteLine("Solo se pueden ingresar numeros del 33 al 255");
            while (salir == "n")                    // esto es para que se repita el programa si el que lo ejecuta quiere seguir en el.
            {

                Console.Write("\nCovertir de numero a caracter: ");
                string mensaje;
                mensaje = Console.ReadLine();
                Console.Write("Su caracter es:");
                Console.WriteLine(ASCII(mensaje));

                Console.WriteLine("\n¿Desea salir [s|n]");
                salir = Console.ReadLine();
            }
           
        }

        static string ASCII(String code)
        {
            // Su funcion es que cada vez que yo ingrese un numero el programa muestre por pantalla el caracter que ese numero tiene asignado.
            string codex = code.ToUpper().Replace("33", "!").Replace("35", "#").Replace("36", "#").Replace("37", "%")
                                         .Replace("38", "&").Replace("39", "´").Replace("40", "(").Replace("41", ")").Replace("42", "*")
                                         .Replace("43", "+").Replace("44", ",").Replace("45", "-").Replace("46", ".").Replace("47", "/")
                                         .Replace("47", "/").Replace("48", "0").Replace("49", "1").Replace("50", "2").Replace("51", "3")
                                         .Replace("52", "4").Replace("53", "5").Replace("54", "6").Replace("55", "7").Replace("56", "8")
                                         .Replace("57", "9").Replace("58", ":").Replace("59", ";").Replace("60", "<").Replace("61", "=")
                                         .Replace("62", ">").Replace("63", "?").Replace("64", "@")

                                         //AQUI DECIDI COLORCAR LOS NUMEROS POR COLUMMNAS

                                         .Replace("65", "A").Replace("96", "`").Replace("128", "Ç").Replace("160", "á").Replace("192", "└").Replace("224", "Ó")
                                         .Replace("66", "B").Replace("97", "a").Replace("129", "ü").Replace("161", "í").Replace("193", "┴").Replace("225", "ß")
                                         .Replace("67", "C").Replace("98", "b").Replace("130", "é").Replace("162", "ó").Replace("194", "┬").Replace("226", "Ô")
                                         .Replace("68", "D").Replace("99", "c").Replace("131", "â").Replace("163", "ú").Replace("195", "├").Replace("227", "Ò")
                                         .Replace("69", "E").Replace("100", "d").Replace("132", "ä").Replace("164", "ñ").Replace("196", "─").Replace("228", "õ")
                                         .Replace("70", "F").Replace("101", "e").Replace("133", "à").Replace("165", "Ñ").Replace("197", "┼").Replace("229", "Õ")
                                         .Replace("71", "G").Replace("102", "f").Replace("134", "å").Replace("166", "ª").Replace("198", "ã").Replace("230", "µ")
                                         .Replace("72", "H").Replace("103", "g").Replace("135", "ç").Replace("167", "º").Replace("199", "Ã").Replace("231", "þ")
                                         .Replace("73", "I").Replace("104", "h").Replace("136", "ê").Replace("168", "¿").Replace("200", "╚").Replace("232", "Þ")
                                         .Replace("74", "J").Replace("105", "i").Replace("137", "ë").Replace("169", "®").Replace("201", "╔").Replace("233", "Ú")
                                         .Replace("75", "K").Replace("106", "j").Replace("138", "è").Replace("170", "¬").Replace("202", "╩").Replace("234", "Û")
                                         .Replace("76", "L").Replace("107", "k").Replace("139", "ï").Replace("171", "½").Replace("203", "╦").Replace("235", "Ù")
                                         .Replace("77", "M").Replace("108", "l").Replace("140", "î").Replace("172", "¼").Replace("204", "╠").Replace("236", "ý")
                                         .Replace("78", "N").Replace("109", "m").Replace("141", "ì").Replace("173", "¡").Replace("205", "═").Replace("237", "Ý")
                                         .Replace("79", "O").Replace("110", "n").Replace("142", "Ä").Replace("174", "«").Replace("206", "╬").Replace("238", "¯")
                                         .Replace("80", "P").Replace("111", "o").Replace("143", "Å").Replace("175", "»").Replace("207", "¤").Replace("239", "´")
                                         .Replace("81", "Q").Replace("112", "p").Replace("144", "É").Replace("176", "░").Replace("208", "ð").Replace("240", "≡")
                                         .Replace("82", "R").Replace("113", "q").Replace("145", "æ").Replace("177", "▒").Replace("209", "Ð").Replace("241", "±")
                                         .Replace("83", "S").Replace("114", "r").Replace("146", "Æ").Replace("178", "▓").Replace("210", "Ê").Replace("242", "‗")
                                         .Replace("84", "T").Replace("115", "s").Replace("147", "ô").Replace("179", "│").Replace("211", "Ë").Replace("243", "¾")
                                         .Replace("85", "U").Replace("116", "t").Replace("148", "ö").Replace("180", "┤").Replace("212", "È").Replace("244", "¶")
                                         .Replace("86", "V").Replace("117", "u").Replace("149", "ò").Replace("181", "Á").Replace("213", "ı").Replace("245", "§")
                                         .Replace("87", "W").Replace("118", "v").Replace("150", "û").Replace("182", "Á").Replace("214", "Í").Replace("246", "÷")
                                         .Replace("88", "X").Replace("119", "w").Replace("151", "ù").Replace("183", "À").Replace("215", "î").Replace("247", "ç")
                                         .Replace("89", "Y").Replace("120", "x").Replace("152", "ÿ").Replace("184", "©").Replace("216", "Ï").Replace("248", "°")
                                         .Replace("90", "Z").Replace("121", "y").Replace("153", "Ö").Replace("185", "╢").Replace("217", "┘").Replace("249", "¨")
                                         .Replace("91", "[").Replace("122", "z").Replace("154", "Ü").Replace("186", "║").Replace("218", "┌").Replace("250", "·")
                                                            .Replace("123", "{").Replace("155", "ø").Replace("187", "╗").Replace("219", "█").Replace("251", "¹")
                                         .Replace("93", "]").Replace("124", "|").Replace("156", "£").Replace("188", "╝").Replace("220", "▄").Replace("252", "³")
                                         .Replace("94", "^").Replace("125", "}").Replace("157", "ø").Replace("189", "¢").Replace("221", "¦").Replace("253", "³")
                                         .Replace("95", "_").Replace("126", "~").Replace("158", "x").Replace("190", "¥ ").Replace("222", "ì").Replace("254", "■")
                                                                                .Replace("159", "ƒ").Replace("191", "┐").Replace("223", "▀").Replace("255", " ")
                                         .Replace("92", "barra invertida")
                                         ;

            return codex;


        }
    }
}
