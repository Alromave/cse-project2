class Word
{
    private bool isHidden;
    private string value;
    public string Value{
        get { return value;}
    }
    public bool IsHidden{
        get{ return isHidden;}
    }

    public Word(string text){
        isHidden = false;
        value = text;
    }

    public void Hide(){
        isHidden = true;
    }
}

   