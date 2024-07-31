printfn "Nabin Oli"

type Cuisine =
    | Korean
    | Turkish


type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks


type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float


let calculateBudget activity =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie movieType ->
        match movieType with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive(kms, fuelPerKm) -> float kms * fuelPerKm


let activities = [
    BoardGame
    Chill
    Movie Regular
    Movie IMAXWithSnacks
    Restaurant Korean
    LongDrive(100, 1.2)
]

for activity in activities do
    let cost = calculateBudget activity
    printfn "The cost for %A is %f CAD" activity cost
