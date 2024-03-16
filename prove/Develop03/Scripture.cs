public class Scripture
{
    private string reference;
    private List<Word> text = new List<Word>();
    public string Reference{
        get { return reference;}
    }
    public Scripture(string myReference, string myText){
        reference = myReference;
        string[] substrnigs = myText.Split(" ");
        foreach (string substrnig in substrnigs){
            Word newWord = new Word(substrnig);
            text.Add(newWord);
        }
    }

    public string DisplayVerse(){
        string txt = "";
        foreach (Word word in text){
            if (word.IsHidden){
                txt += new string('_', word.Value.Length) + ' ';
            }
            else {
                txt += word.Value + " ";
            }
        }
        return txt.Trim();
    }

    public void EraseRandomWord(){
        Random random = new Random();
        bool isWordAlreadyHidden = true;
        if(text.Count == 0){
            throw new InvalidOperationException("Verse text is empty!");
        }
        while(isWordAlreadyHidden){
            int randomIndex = random.Next(0, text.Count);
            isWordAlreadyHidden = text[randomIndex].IsHidden;
            if(isWordAlreadyHidden == false){
                text[randomIndex].Hide();
            }
        }
    }

    public bool isAllVerseHidden(){
        if(text.Count <= 1){
            return true;
        }

        foreach(Word word in text){
            if(word.IsHidden == false){
                return false;
            }
        }
        return true;
    }
    
}