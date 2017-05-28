import { BaseResponse } from '../../root.models.ts';

export class ResponseStatus {
    public errorCode: string;
    public message: string;
    public stackTrace: string;
    public errors: ResponseError[];
}

export class ResponseError {
    public errorCode: string;
    public fieldName: string;
    public message: string;
}

export class ConstituentSearchRecord {
    public id: number;
    public name: string;
    public address: string;
    public phone: string;
    public city: string;
    public state: string;
    public postalCode: string;
}

export class ConstituentSearchRequest {
    public firstName: string;
    public lastName: string;
    public address: string;
    public city: string;
    public sSN: string;
}

export class ConstituentSearchResponse extends BaseResponse {
    public records: ConstituentSearchRecord[];
}

