using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Money
{
    public class WordFill
    {

        public void PreencherPorReplace(string CaminhoDocMatriz, string favorecido, string Valor, string valor, string referente, DateTime data, string emissor, string cpf, string extenso)
        {


            //Objeto a ser usado nos parâmetros opcionais
            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado
            Microsoft.Office.Interop.Word.Application oApp = new Microsoft.Office.Interop.Word.Application();
            object template = CaminhoDocMatriz; 
            Microsoft.Office.Interop.Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags
            Microsoft.Office.Interop.Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "@Favorecido";
            object ReplaceWith = favorecido;

            object MatchWholeWord = true;
            object Forward = false;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);

            //***********************************

            FindText = "@Valor";
            ReplaceWith = Valor;                       

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);


            FindText = "@Extenso";
            ReplaceWith = extenso;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);







            FindText = "@valor";
            ReplaceWith = valor;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);


            FindText = "@Data";
            ReplaceWith = data.ToLongDateString();           

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);



            FindText = "@cpf";
            ReplaceWith = cpf;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);






            FindText = "@Referente";
            ReplaceWith = referente;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);



            FindText = "@Emissor";
            ReplaceWith = emissor;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
            oRng = oDoc.Range(ref missing, ref missing);
            oApp.Visible = true;
        
        }
         
    }
}
