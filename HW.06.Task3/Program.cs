using System.Data;

string text = "as3df45hgy+gcfr67jhmn*vnb3gjbg/fjgnj2dlg-hfvb5";
string textNew = text.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "")
    .Replace("g", "").Replace("h", "").Replace("k", "").Replace("m", "").Replace("n", "").Replace("l", "").Replace("o", "")
    .Replace("p", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("v", "").Replace("q", "").Replace("w", "")
    .Replace("x", "").Replace("z", "").Replace("j", "").Replace("y", "");
Console.WriteLine(textNew);

DataTable dt = new DataTable();
var result = dt.Compute(textNew, "");
Console.WriteLine(result);