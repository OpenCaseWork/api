import { Constituent } from './constituents.models';
import { ConstituentContact } from './constituents.models';

export class ConstituentAggregate {
  public constituent: Constituent;
  public contacts: ConstituentContact[];
  public jsonEntity: any;
  public jsonEntityId: number;
};
