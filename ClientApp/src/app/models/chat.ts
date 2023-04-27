import { Message } from "./message";

export class Chat {
    id?: number;
    Name = "";
    Messages?: Message[];
    //public virtual ICollection<ChatUser> ChatUsers { get; set; }
}