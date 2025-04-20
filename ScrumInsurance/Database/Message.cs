using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Utilities;

namespace ScrumInsurance
{
    public class Message
    {
        public string ID { get; set; }
        public string SenderID { get; set; }
        public string Sender {  get; set; }
        public string RecipientID { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public Message(Row row)
        {
            if (row.Columns.TryGetValue("id", out var id)) ID = id.ToString();
            if (row.Columns.TryGetValue("sender_id", out var sender)) SenderID = sender.ToString();
            if (row.Columns.TryGetValue("recipient_id", out var recipient)) RecipientID = recipient.ToString();
            if (row.Columns.TryGetValue("subject", out var subject)) Subject = subject.ToString();
            if (row.Columns.TryGetValue("content", out var content)) Content = content.ToString();
            if (row.Columns.TryGetValue("date", out var date)) Date = date.ToString();
        }

        public override string ToString()
        {
            return $"ID: {ID}, Subject: {Subject}, Sender: {Sender}, Recipient: {Recipient}, Date: {Date}, Content: {Content}";
        }
    }
}
