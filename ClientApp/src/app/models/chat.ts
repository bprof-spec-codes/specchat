import { Message } from "./message";

export class Chat {
    id?: number;
    name = "";
    Messages?: Message[];
    //public virtual ICollection<ChatUser> ChatUsers { get; set; }
}