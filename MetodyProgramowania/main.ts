// system metod & class --------------------------------------------------------------------------------------------------------------------------

class Card {
    constructor(public name: string, public surname: string, public cardId: number) {
    }
}

enum zoneType {
    OuterZone = "Strefa Zewnętrzna",
    LoadingZone = "Strefa Załadunku/Rozładunku",
    SortingZone = "Strefa Sortowania",
    WarehouseZone = "Strefa Magazynu",
    AirstripZone = "Strefa AirStrip"
}

class Zone {
    name: zoneType;
    members: Array<Card> = [];
    accessPolicy: Array<(x: Card) => boolean> = [];

    constructor(name: zoneType) {
        this.name = name;
    };

    addAccessPolicy(fun: (x: Card) => boolean): void {
        this.accessPolicy.push(fun);
    }

    isAccess(Card: Card): boolean {
        let status = true;
        this.accessPolicy.forEach(x => {
            if (x(Card) == false) {
                status = false;
            }
        })
        return status;
    }

    addCard(Card: Card): boolean {
        if (this.isAccess(Card)) {
            this.members.push(Card);
            return true;
        }
        else {
            return false;
        }
    }

    removeCard(Card: Card): void {
        this.members = this.members.filter(obj => obj.cardId !== Card.cardId);
    }
}

function transferCard(Card: Card, startZone: Zone, destinationZone: Zone): boolean {
    if (!startZone.members.some(x => x.cardId == Card.cardId)) return false;
    if (destinationZone.addCard(Card) == false) 
    {        
        return false;
    }
    startZone.removeCard(Card);
    return true;
    
}

function refreshList(zone: Zone, div: string): void {
    var divContent = "";
    zone.members.sort((a,b) => (a.cardId > b.cardId) ? 1 : ((b.cardId > a.cardId) ? -1 : 0));
    zone.members.forEach(element => {
        divContent += `<input name = "`+zone.name+`Worker" type=\"radio\" value="` + element.cardId + `"/><label> Karta: ` + element.cardId + `\t` + element.name + " " + element.surname + `</label><br>`
    });
    (document.getElementById(div) as HTMLElement).innerHTML = divContent;
}

// zone Access Policy -----------------------------------------------------------------------------------------------------------------------------------------

function LoadingZone_RoleOfCard(Card: Card): boolean {
    if (Card.cardId >= 1000) {
        if (LoadingZone.members.filter(x => x.cardId < 1000).length == 0) {
            alert("Odmowa dostępu");
            console.log("Loading Zone - Card " + Card.cardId + " access check - DENIED");
            return false;
        }
    }
    console.log("Loading Zone - Card " + Card.cardId + " access check - OK");
    return true;
}

function LoadingZone_CardLimit(Card: Card): boolean {
    if (LoadingZone.members.length >= 5) {
        if (Card.cardId < 100) {
            console.log("Loading Zone - Card " + Card.cardId + " access check - OK - Menager");
            return true;
        }
        alert("Zbyt dużo pracowników w strefie");
        console.log("Loading Zone - slots available check - DENIED");
        return false;
    }
    console.log("Loading Zone - slots available check - OK");
    return true;
}

function SortingZone_RoleOfCard(Card: Card): boolean {
    if (Card.cardId >= 501) {
        if (Card.cardId >= 501 && Card.cardId <= 999) {
            alert("Odmowa dostępu");
            console.log("Sorting Zone - Card " + Card.cardId + " access check - DENIED");
            return false;
        }
        if (SortingZone.members.filter(x => x.cardId < 1000).length == 0) {
            alert("Odmowa dostępu");
            console.log("Sorting Zone - Card " + Card.cardId + " access check - DENIED");
            return false;
        }
    }
    console.log("Sorting Zone - Card " + Card.cardId + " access check - OK");
    return true;
}

function SortingZone_CardLimit(Card: Card): boolean {
    if (SortingZone.members.length >= 7) {
        if (Card.cardId < 100) {
            console.log("Sorting Zone - Card " + Card.cardId + " access check - OK - Menager");
            return true;
        }
        alert("Zbyt dużo pracowników w strefie");
        console.log("Sorting Zone - slots available check - DENIED");
        return false;
    }
    console.log("Sorting Zone - slots available check - OK");
    return true;
}

function WarehouseZone_RoleOfCard(Card: Card): boolean {
    if (Card.cardId >= 100 && Card.cardId <=200) {
        alert("Odmowa dostępu");
        console.log("Warehouse Zone - Card " + Card.cardId + " access check - DENIED");
        return false;
    }
    if (Card.cardId >= 501) {
        if (Card.cardId >= 501 && Card.cardId <= 999) {
            alert("Odmowa dostępu");
            console.log("Warehouse Zone - Card " + Card.cardId + " access check - DENIED");
            return false;
        }
        if (WarehouseZone.members.filter(x => x.cardId < 1000).length == 0) {
            alert("Odmowa dostępu");
            console.log("Warehouse Zone - Card " + Card.cardId + " access check - DENIED");
            return false;
        }
    }
    console.log("Warehouse Zone - Card " + Card.cardId + " access check - OK");
    return true;
}

function WarehouseZone_CardLimit(Card: Card): boolean {
    if (WarehouseZone.members.length >= 3) {
        if (Card.cardId < 100) {
            console.log("Warehouse Zone - Card " + Card.cardId + " access check - OK - Menager");
            return true;
        }
        alert("Zbyt dużo pracowników w strefie");
        console.log("Warehouse Zone - slots available check - DENIED");
        return false;
    }
    console.log("Warehouse Zone - slots available check - OK");
    return true;
}

function AirstripZone_RoleOfCard(Card: Card): boolean {
    if (Card.cardId >= 201) {
        alert("Odmowa dostępu");
        console.log("Airstrip Zone - Card " + Card.cardId + " access check - DENIED");
        return false;
    }
    console.log("Airstrip Zone - Card " + Card.cardId + " access check - OK");
    return true;
}

function AirstripZone_CardLimit(Card: Card): boolean {
    if (AirstripZone.members.length >= 3) {
        alert("Zbyt dużo pracowników w strefie");
        console.log("Airstrip Zone - slots available check - DENIED");
        return false;
    }
    console.log("Airstrip Zone - slots available check - OK");
    return true;
}

// system Zone init  -------------------------------------------------------------------------------------------------------------------------------------------

let OuterZone = new Zone(zoneType.OuterZone);

let LoadingZone = new Zone(zoneType.LoadingZone);
LoadingZone.addAccessPolicy(LoadingZone_RoleOfCard);
LoadingZone.addAccessPolicy(LoadingZone_CardLimit);

let SortingZone = new Zone(zoneType.SortingZone);
SortingZone.addAccessPolicy(SortingZone_RoleOfCard);
SortingZone.addAccessPolicy(SortingZone_CardLimit);

let WarehouseZone = new Zone(zoneType.WarehouseZone);
WarehouseZone.addAccessPolicy(WarehouseZone_RoleOfCard);
WarehouseZone.addAccessPolicy(WarehouseZone_CardLimit);

let AirstripZone = new Zone(zoneType.AirstripZone);
AirstripZone.addAccessPolicy(AirstripZone_RoleOfCard);
AirstripZone.addAccessPolicy(AirstripZone_CardLimit);


// system Action -----------------------------------------------------------------------------------------------------------------------------------------------

// list refresh

function refreshList_OuterZone() {
    refreshList(OuterZone, 'list-of-workers-in-outer-zone');
}

function refreshList_LoadingZone() {
    refreshList(LoadingZone, 'list-of-workers-in-loading-zone');
}

function refreshList_SortingZone() {
    refreshList(SortingZone, 'list-of-workers-in-sorting-zone');
}

function refreshList_WarehouseZone() {
    refreshList(WarehouseZone, 'list-of-workers-in-warehouse-zone');
}

function refreshList_AirstripZone() {
    refreshList(AirstripZone, 'list-of-workers-in-airstrip-zone');
}

// button action

let workerInit = false;

function LoadWorkersList() {
    if (workerInit == false) {
        workerInit = true;
        OuterZone.addCard(new Card("Remigiusz", "Mazurek", 22));
        OuterZone.addCard(new Card("Maurycy", "Sokołowski", 107));
        OuterZone.addCard(new Card("Dorian", "Kowalski", 123));
        OuterZone.addCard(new Card("Ariel", "Szczepański", 186));
        OuterZone.addCard(new Card("Dobromił", "Baran", 230));
        OuterZone.addCard(new Card("Gniewomir", "Wróblewski", 254));
        OuterZone.addCard(new Card("Amir", "Woźniak", 351));
        OuterZone.addCard(new Card("Alex", "Ostrowski", 412));
        OuterZone.addCard(new Card("Cezary", "Kaźmierczak", 665));
        OuterZone.addCard(new Card("Błażej", "Szulc", 725));
        OuterZone.addCard(new Card("Marcel", "Malinowski", 1032));
        OuterZone.addCard(new Card("Kornel", "Chmielewski", 1128));
    }
    refreshList_OuterZone();
};

function doorButtonAction_OuterZone_To_LoadingZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.OuterZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = OuterZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, OuterZone, LoadingZone);
        refreshList_OuterZone();
        refreshList_LoadingZone();
    }
}

function doorButtonAction_LoadingZone_To_OuterZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.LoadingZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = LoadingZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, LoadingZone, OuterZone);
        refreshList_OuterZone();
        refreshList_LoadingZone();
    }
}

function doorButtonAction_LoadingZone_To_SortingZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.LoadingZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = LoadingZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, LoadingZone, SortingZone);
        refreshList_LoadingZone();
        refreshList_SortingZone();
    }
}

function doorButtonAction_SortingZone_To_LoadingZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.SortingZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = SortingZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, SortingZone, LoadingZone);
        refreshList_SortingZone();
        refreshList_LoadingZone();
    }
}

function doorButtonAction_SortingZone_To_WarehouseZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.SortingZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = SortingZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, SortingZone, WarehouseZone);
        refreshList_SortingZone();
        refreshList_WarehouseZone();
    }
}

function doorButtonAction_WarehouseZone_To_SortingZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.WarehouseZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = WarehouseZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, WarehouseZone, SortingZone);
        refreshList_SortingZone();
        refreshList_WarehouseZone();
    }
}

function doorButtonAction_SortingZone_To_AirstripZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.SortingZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = SortingZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, SortingZone, AirstripZone);
        refreshList_SortingZone();
        refreshList_AirstripZone();
    }
}

function doorButtonAction_AirstripZone_To_SortingZone() {
    let cardid = (document.querySelector(`input[name = "`+zoneType.AirstripZone+`Worker"]:checked`) as HTMLInputElement)?.value;
    if (cardid != null) {
        let Card = AirstripZone.members.filter(x => x.cardId == Number(cardid))[0];
        transferCard(Card, AirstripZone, SortingZone);
        refreshList_SortingZone();
        refreshList_AirstripZone();
    }
}

// add new worker Form

function OpenAddWorkerForm() {
    (document.getElementById('add-worker-form-wrapper') as HTMLElement).style.visibility = "visible";
}
function CloseAddWorkerForm() {
    (document.getElementById('add-worker-form-wrapper') as HTMLElement).style.visibility = "hidden";
}
var zonesList: Array<Zone> = [OuterZone, LoadingZone, SortingZone, WarehouseZone, AirstripZone];
function AddWorker() {
    var workerId: number = Number((document.getElementById("worker-id") as HTMLInputElement).value);
    var workerName = (document.getElementById("worker-name") as HTMLInputElement).value;
    var workerSurname = (document.getElementById("worker-surname") as HTMLInputElement).value;

    var isIdTaken:boolean = false;

    for(var checkedZone of zonesList)
    {
        if(checkedZone.members[workerId] != null)
        {
            isIdTaken = true;
        }
    }
    if(isIdTaken == false)
    {
        OuterZone.addCard(new Card(workerName, workerSurname, workerId));
        alert("Dodano: " + workerName + " " + workerSurname + "\nID karty: " + workerId);
        console.log("New worker added successfully! Id: " + workerId + " Name: " + workerName + " " + workerSurname);
        CloseAddWorkerForm();
        refreshList_OuterZone();
    }
    else
    {        
        alert("To ID jest już zajęte!");
        console.log("New worker ID denied! Id: " + workerId);
    }   
}

class Tester
{
    clearAllZones(): void
    {
        LoadingZone.members=[];
        SortingZone.members=[];
        AirstripZone.members=[];
        WarehouseZone.members=[];
    }
    //dostęp dozorcy do strefy zależnie od obecności innego pracownika
    isJanitorAllowed(): boolean 
    {        
        // arrange
        var janitor : Card = new Card("Kornel", "Chmielewski", 1500);
        OuterZone.members.push(janitor);
        var transportWorker : Card = new Card("Tomasz", "Kwiatkowski", 620);
        OuterZone.members.push(transportWorker);

        //act
        var isJanitorAllowed_1 : boolean = transferCard(janitor, OuterZone, LoadingZone); //dozorca próbuje wejść do pustej strefy ładowania - oczekiwana odmowa
        var isTransportWorkerAllowed : boolean = transferCard(transportWorker, OuterZone, LoadingZone); //pracownik transportu próbuje weść do pustej strefy ładowania - oczekiwana akceptacja
        var isJanitorAllowed_2 : boolean = transferCard(janitor, OuterZone, LoadingZone); //dozorca próbuje wejść do strefy ładowania po innym pracowniku - oczekiwana akceptacja

        //assert
        if((isJanitorAllowed_1 == false) && (isTransportWorkerAllowed == true) && (isJanitorAllowed_2 == true))
        {
            console.log("Janitor access test successful");
            return true;
        }
        else
        {
            console.log("Janitor access test UNSUCCESSFUL");
            return false;
        }

        //clean
        this.clearAllZones();
    }

    isSlotAvailable() : boolean
    {
        //arrange
        var worker_1 : Card = new Card("Kornel", "Chmielewski", 100);
        var worker_2 : Card = new Card("Kornel", "Chmielewski", 1500);
        var worker_3 : Card = new Card("Kornel", "Chmielewski", 600);
        var worker_4 : Card = new Card("Kornel", "Chmielewski", 500);
        var worker_5 : Card = new Card("Kornel", "Chmielewski", 230);
        var menager : Card = new Card("Kornel", "Chmielewski", 1); //menedżer - oczekiwany dostęp niezależnie od ilości pracowników w strefie

        //uzupełnianie maksymalną ilością pracowników strefy ładowania
        LoadingZone.members.push(worker_1);
        LoadingZone.members.push(worker_2);
        LoadingZone.members.push(worker_3);
        LoadingZone.members.push(worker_4);
        OuterZone.members.push(worker_5);
        OuterZone.members.push(menager);

        //act
        var isWorkerAllowed:boolean = transferCard(worker_5, OuterZone, LoadingZone); //próba przejścia pracownika do pełnej strefy - oczekiwana odmowa
        var isMenagerAllowed:boolean = transferCard(menager, OuterZone, LoadingZone); //próba przejścia pracownika do pełnej strefy - oczekiwana odmowa

        //assert
        if((isWorkerAllowed == false) && (isMenagerAllowed == true))
        {
            console.log("Number of workers test successful");
            return true;
        }
        else
        {
            console.log("Number of workers test UNSUCCESSFUL");
            return false;
        }  

        //clean
       this.clearAllZones();
    }
    accessToZone(): boolean
    {
        //arrange
        var menager : Card = new Card("Kornel", "Chmielewski", 1);
        var airstripZoneWorker : Card = new Card("Kornel", "Chmielewski", 101);
        var sortingZoneWorker : Card = new Card("Kornel", "Chmielewski", 201);
        var transportWorker : Card = new Card("Kornel", "Chmielewski", 501);
        var janitor : Card = new Card("Kornel", "Chmielewski", 1000);

        OuterZone.members.push(menager);
        OuterZone.members.push(airstripZoneWorker);
        OuterZone.members.push(sortingZoneWorker);
        OuterZone.members.push(transportWorker);
        OuterZone.members.push(janitor);

        //act
        //menager-----------------------------------------------
        var menager_LoadingZone_Access : boolean = transferCard(menager, OuterZone, LoadingZone); //oczekiwana akceptacja
        var menager_SortingZone_Access : boolean = transferCard(menager, LoadingZone, SortingZone); //oczekiwana akceptacja
        var menager_WarehouseZone_Access : boolean = transferCard(menager, SortingZone, WarehouseZone); //oczekiwana akceptacja
        transferCard(menager, WarehouseZone, SortingZone); //powrót przez sorting zone
        var menager_AirstripZone_Access : boolean = transferCard(menager, SortingZone, AirstripZone); //oczekiwana akceptacja
        this.clearAllZones();
        //------------------------------------------------------

        //airstrip zone worker---------------------------------------
        var airstripZoneWorker_LoadingZone_Access : boolean = transferCard(airstripZoneWorker, OuterZone, LoadingZone); //oczekiwana akceptacja
        var airstripZoneWorker_SortingZone_Access : boolean = transferCard(airstripZoneWorker, LoadingZone, SortingZone); //oczekiwana akceptacja
        var airstripZoneWorker_AirstripZone_Access : boolean = transferCard(airstripZoneWorker, SortingZone, AirstripZone); //oczekiwana akceptacja
        transferCard(airstripZoneWorker, AirstripZone, SortingZone); //powrót z airstrip zone przez sorting zone
        var airstripZoneWorker_WarehouseZone_Access : boolean = transferCard(airstripZoneWorker, SortingZone, WarehouseZone); //oczekiwana odmowa
        this.clearAllZones();
        //------------------------------------------------------

        //sorting zone worker-----------------------------------
        var sortingZoneWorker_LoadingZone_Access : boolean = transferCard(sortingZoneWorker, OuterZone, LoadingZone); //oczekiwana akceptacja
        var sortingZoneWorker_SortingZone_Access : boolean = transferCard(sortingZoneWorker, LoadingZone, SortingZone); //oczekiwana akceptacja
        var sortingZoneWorker_WarehouseZone_Access : boolean = transferCard(sortingZoneWorker, SortingZone, WarehouseZone); //oczekiwana akceptacja
        transferCard(airstripZoneWorker, WarehouseZone, SortingZone); //powrót z warehouse zone przez sorting zone
        var sortingZoneWorker_AirstripZone_Access : boolean = transferCard(sortingZoneWorker, SortingZone, AirstripZone); //oczekiwana odmowa
        this.clearAllZones();
        //------------------------------------------------------
        
        //transport worker--------------------------------------
        var transportWorker_LoadingZone_Access : boolean = transferCard(transportWorker, OuterZone, LoadingZone); //oczekiwana akceptacja
        var transportWorker_SortingZone_Access : boolean = transferCard(transportWorker, LoadingZone, SortingZone); //oczekiwana odmowa
        this.clearAllZones();
        SortingZone.members.push(transportWorker); //testowe wymuszenie dodania do sorting zone
        var transportWorker_WarehouseZone_Access : boolean = transferCard(transportWorker, SortingZone, WarehouseZone); //oczekiwana odmowa
        transferCard(transportWorker, WarehouseZone, SortingZone); //powrót z warehouse zone przez sorting zone
        this.clearAllZones();
        SortingZone.members.push(transportWorker); //testowe wymuszenie dodania do sorting zone
        var transportWorker_AirstripZone_Access : boolean = transferCard(transportWorker, SortingZone, AirstripZone); //oczekiwana odmowa
        this.clearAllZones();
        //------------------------------------------------------

        //janitor ----------------------------------------------
        //pracownicy towarzyszący dozorcy:
        LoadingZone.members.push(new Card("","", 2)); 
        SortingZone.members.push(new Card("","", 3)); 
        WarehouseZone.members.push(new Card("","", 4)); 
        AirstripZone.members.push(new Card("","", 5));  
             
        var janitor_LoadingZone_Access : boolean = transferCard(janitor, OuterZone, LoadingZone); //oczekiwana akceptacja
        var janitor_SortingZone_Access : boolean = transferCard(janitor, LoadingZone, SortingZone); //oczekiwana akceptacja
        var janitor_WarehouseZone_Access : boolean = transferCard(janitor, SortingZone, WarehouseZone); //oczekiwana akceptacja
        transferCard(janitor, WarehouseZone, SortingZone); //powrót przez sorting zone
        var janitor_AirstripZone_Access : boolean = transferCard(janitor, SortingZone, AirstripZone); //oczekiwana odmowa
        this.clearAllZones();
        //------------------------------------------------------        
        

        //assert
        var menagerCorrect: boolean = false;
        var airstripZoneWorkerCorrect: boolean = false;
        var sortingZoneWorkerCorrect: boolean = false;
        var transportWorkerCorrect: boolean = false;
        var janitorCorrect: boolean = false;

        if ((menager_LoadingZone_Access == true) && (menager_SortingZone_Access == true) && (menager_WarehouseZone_Access == true) && (menager_AirstripZone_Access == true))
        {
            menagerCorrect = true;
        }
        if ((airstripZoneWorker_LoadingZone_Access == true) && (airstripZoneWorker_SortingZone_Access == true) && (airstripZoneWorker_WarehouseZone_Access == false) && (airstripZoneWorker_AirstripZone_Access == true))
        {
            airstripZoneWorkerCorrect = true;
        }
        if ((sortingZoneWorker_LoadingZone_Access == true) && (sortingZoneWorker_SortingZone_Access == true) && (sortingZoneWorker_WarehouseZone_Access == true) && (sortingZoneWorker_AirstripZone_Access == false))
        {
            sortingZoneWorkerCorrect = true;
        }
        if ((transportWorker_LoadingZone_Access == true) && (transportWorker_SortingZone_Access != true) && (transportWorker_WarehouseZone_Access != true) && (transportWorker_AirstripZone_Access != true))
        {
            transportWorkerCorrect = true;
        }
        if ((janitor_LoadingZone_Access == true) && (janitor_SortingZone_Access == true) && (janitor_WarehouseZone_Access == true) && (janitor_AirstripZone_Access == false))
        {
            janitorCorrect = true;
        }
        if(menagerCorrect && airstripZoneWorkerCorrect && sortingZoneWorkerCorrect && transportWorkerCorrect && janitorCorrect)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}