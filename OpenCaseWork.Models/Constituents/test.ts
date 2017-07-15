import { AuditedEntity } from '../Audit/audit.models';
import { SelectItem } from '../Domains/domains.models';

/*[Table("constituent")]*/
export class Constituent extends AuditedEntity {
  /*[Column("constituent_id")]*/
  public constituentId: number;
  /*[Column("title_id")]*/
  public titleId: number;
  public title: SelectItem;
  /*[Column("first_name")]*/
  public firstName: string;
  /*[Column("last_name")]*/
  public lastName: string;
  /*[Column("middle_name")]*/
  public middleName: string;
  /*[Column("suffix_id")]*/
  public suffixId: number;
  public suffix: SelectItem;
  public nickName: string;
  /*[Column("addr1")]*/
  public address1: string;
  /*[Column("addr2")]*/
  public address2: string;
  /*[Column("city_id")]*/
  public cityId: number;
  public city: SelectItem;
  /*[Column("township_id")]*/
  public townshipId: number;
  public township: SelectItem;
  /*[Column("state_id")]*/
  public stateId: number;
  public state: SelectItem;
  public get stateCd(): string {
    return this.state.code;
  }
  /*[Column("zip_id")]*/
  public postalCodeId: number;
  public postalCode: SelectItem;
  private get postalCodeValue(): string {
    return this.postalCode.code;
  }
  /*[Column("federal_id")]*/
  public federalId: string;
  /*[Column("birth_date")]*/
  public birthDate: Date;
  /*[Column("gender")]*/
  public genderId: number;
  public gender: SelectItem;
  /*[Column("minority_id")]*/
  public minorityId: number;
  public minority: SelectItem;
  public get incomeLevelId(): number {
    return this.incomeLevel.id;
  }
  public set incomeLevelId(value: number) {
    this.incomeLevel.id = value;
  }
  public incomeLevel: SelectItem;
  /*[Column("maiden_name")]*/
  public maidenName: string;
  /*[Column("living_alone")]*/
  public livingAlone: boolean;
  /*[Column("lives_in_nursing_home")]*/
  public livesInNursingHome: boolean;
  /*[Column("frail_disabled")]*/
  public frailDisabled: boolean;
  /*[Column("limited_english")]*/
  public limitedEnglish: boolean;
  /*[Column("case_worker_risk")]*/
  public caseWorkerRisk: boolean;
  /*[Column("homeless")]*/
  public homeless: boolean;
  /*[Column("female_headed_household")]*/
  public femaleHeadedHousehold: boolean;
  /*[Column("pet")]*/
  public pet: boolean;
}