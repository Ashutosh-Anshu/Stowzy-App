import { LockerDocument } from "./business-documents";
import { Locker } from "./locker";
import { Owner } from "./owner";

export interface OwnerRegistration {         
    owner: Owner;          
    locker: Locker;
    lockerDocument:LockerDocument;   
}