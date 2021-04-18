namespace SERVER
{
    public class REIS
    {
        public string id_town; // идентификатор
        public string town; // город назначения
        public string data; // дата и время отправки
        private int colvo; // количество
        public REIS(string id_town, string town, string data, int colvo)
        {
            this.id_town = id_town;
            this.town = town;
            this.data = data;
            this.colvo = colvo;
        }

        public void izmencolvo(int value)//функция изменения количества билетов
        {
            this.colvo = value;
        }
        public int poluchncolvo()//функция получения количества билетов
        {
            return colvo;
        }
    }
}