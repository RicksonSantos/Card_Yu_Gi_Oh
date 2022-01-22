namespace cards_Yu_Gi_Oh.src.Entities
{
      public class trevas
    {

        public trevas (string Name, int Level, string attribute){
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
            return "Ataque de 1600 e defesa de 1200. ";

        
        }



        public string Name;
        public int Level;
        public string attribute;





    }
}
