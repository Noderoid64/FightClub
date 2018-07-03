using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
   public class Model : IObservable
    {
        FightRoomForTwo FR;
        public Model()
        {
            observers = new List<IObserver>();
        }
        public void StartRound(RoomCreator RC)
        {
            FR = RC.Create();
            FR.First.Death += SendDeath;
            FR.First.Block += SendBlock;
            FR.First.Attack += SendDamage;

            FR.Second.Death += SendDeath;
            FR.Second.Block += SendBlock;
            FR.Second.Attack += SendDamage;
            Notify(FR);
        }
        public void SetPart(Player.Part part)
        {
            FR.SetPart(part);
            Notify(FR);
        }

        private void SendDeath(PlayerArgs pa)
        {
            NotifyString("Death",pa);
        }
        private void SendDamage(PlayerArgs pa)
        {
            NotifyString("Damage", pa);
        }
        private void SendBlock(PlayerArgs pa)
        {
            NotifyString("Block", pa);
        }
        private void NotifyString(string header, PlayerArgs pa)
        {
            string message = header + $"\n" +
                $"Name: {pa.Name ?? "NoName"}\n" +
                $"Hp: {pa.HP.ToString() ?? "-"}/{pa.MaxHP.ToString() ?? "-"}\n" +
                $"Blocked part: {pa.Block.ToString()??"-"}\n" +
                $"Attack part: {pa.Attack.ToString()??"-"}\n" +
                $"Power: {pa.AttackPower.ToString()??"-"}\n";
            Notify(message);
        }

        public void ClearLog()
        {
            Notify("Clear");
        }

        #region IObservers
        List<IObserver> observers;
        public void AddObserver(IObserver obj)
        {
            observers.Add(obj);
        }
        public void Notify(object info)
        {
            foreach (var observ in observers)
            {
                observ.update(info);
            }
        }
        public void RemoveObserver(IObserver obj)
        {
            observers.Remove(obj);
        }
        #endregion

        
    }
}
