export interface Locker {
    lockerId: string;
    businessName: string;
    businessType: string;
    noOflockers: number;
    lockerSize: string;
    securityMeasures: string;
    hourlyRentalPrice: number;
    streetAddress: string;
    landmark?: string;
    country: string;
    state: string;
    city: string;
    postalCode: string;
    currentLocation: string;
}
