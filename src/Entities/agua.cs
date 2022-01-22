namespace cards_Yu_Gi_Oh.src.Entities
{
    public class agua
    {
     

        public agua (string Name, int Level, string attribute){
            this.Name = Name;
            this.Level = Level;
            this.attribute = attribute;
        }
        
        public override string ToString()
        {
            return this.Name + " Level: " + this.Level + " Atributo: " + this.attribute;
        }

        //Metedo utilizado para a lenda Dragão
        public virtual string Attack (){
            return ("Ataque de 2000 e defesa de 0. ");
        
        }



        public string Name;
        public int Level;
        public string attribute;





    }
}