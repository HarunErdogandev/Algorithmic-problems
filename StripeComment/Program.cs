// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var text = "apples, pears # and bananas\ngrapes\nbananas !apples";

var test1 = "say hello";




var Symbols = new[] { "#", "!" };


Console.WriteLine(StripComments(text,Symbols));



//

static string StripComments(string text, string[] commentSymbols)
{
    // Girdi metnini satırlara böl
    string[] lines = text.Split('\n');

    for (int i = 0; i < lines.Length; i++)
    {
        // Her bir yorum belirtecini kontrol et
        foreach (string marker in commentSymbols)
        {
            // Yorum belirtecinin satırdaki indeksini bul
            int index = lines[i].IndexOf(marker);

            // Eğer yorum belirteci satırda bulunursa
            if (index != -1)
            {
                // Belirteci ve sonrasını sil
                lines[i] = lines[i].Substring(0, index);
            }
        }

        // Satırın sonundaki gereksiz boşlukları sil
        lines[i] = lines[i].TrimEnd();
    }

    // İşlenmiş satırları tekrar birleştir
    return string.Join("\n", lines);
}

static string TrimText(string text) => text.Trim();














