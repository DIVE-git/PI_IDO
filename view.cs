using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_IDO
{
    internal class view
    {
        public static string PrintAllData ()
        {
            return $"ФИО: {model.fio}\r\nДата рождения: {model.birthday.ToString("dd.MM.yyyy")}\r\nПол: {model.gender}\r\nСерия и номер: {model.passportSN}\r\nКем выдан: {model.passportW}\r\nДата выдачи: {model.passportDI.ToString("dd.MM.yyyy")}\r\nУровень образования: {model.eduLvl}\r\nОбразовательная организация: {model.organization}\r\nМестоположение организации: {model.location}\r\nСпециальность: {model.special}\r\nКвалификация: {model.qual}\r\nНомер телефона: {model.phone}\r\nЭлектронная почта: {model.email}\r\nАдрес: {model.address}";
        }
    }
}
