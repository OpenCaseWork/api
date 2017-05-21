export class BaseResponse {
    constructor() {

    }
    public ResponseInfo: ResponseStatus;
}

export class ResponseStatus {
    public ErrorCode: string;
    public Message: string;
    public StackTrace: string;
    public Errors: ResponseError[];
}

export class ResponseError {
    public ErrorCode: string;
    public FieldName: string;
    public Message: string;
}

export class ConstituentSearchRequest {
    public firstName: string;
    public lastName: string;
    public address: string;
    public city: string;
    public SSN: string;
}

export class ConstituentDemographics {
    public livingAlone: boolean;
    public livesInNursingHome: boolean;
    public frailDisabled: boolean;
    public limitedEnglish: boolean;
    public caseWorkerRisk: boolean;
    public homeless: boolean;
    public femaleHeadedHousehold: boolean;
    public pet: boolean;
}

export class Constituent {
    public constituentId: number;
    public titleID: number;
    public firstName: string;
    public lastName: string;
    public middleName: string;
    public suffixID: number;
    public nickname: string;
    public address1: string;
    public address2: string;
    public cityID: number;
    public townshipID: number;
    public stateCd: string;
    public postalCodeID: number;
    public postalCode: string;
    public federalID: string;
    public birthDate: Date;
    public genderId: number;
    public minorityId: number;
    public incomeLevelId: number;
    public maidenName: string;
    public demographics: ConstituentDemographics;
}