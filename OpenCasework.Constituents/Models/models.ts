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