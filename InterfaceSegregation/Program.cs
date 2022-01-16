namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Photograph photograph = new Photograph();
            Phone lumia950 = new Phone();
            photograph.TakePhoto(lumia950);
            
            PhotographSegregation photographSegregation = new PhotographSegregation();
            photographSegregation.TakePhoto(new CameraSegregation());
            photographSegregation.TakePhoto(new PhoneSegregation());
        }
    }
}