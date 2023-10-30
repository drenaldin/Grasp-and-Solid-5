namespace Full_GRASP_And_SOLID
{

    public interface ITextPrint
    {
        string GetTextToPrint();
    }
}


// Cree la interfaz TextPrint para que ConsolePrinter no dependa de Recipe. TextPrint obtiene el texto y ConsolePrinter lo imprime.