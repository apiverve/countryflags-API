declare module '@apiverve/countryflags' {
  export interface countryflagsOptions {
    api_key: string;
    secure?: boolean;
  }

  export interface countryflagsResponse {
    status: string;
    error: string | null;
    data: CountryFlagsData;
    code?: number;
  }


  interface CountryFlagsData {
      country:     string;
      countryCode: string;
      shape:       string;
      format:      string;
      downloadURL: string;
  }

  export default class countryflagsWrapper {
    constructor(options: countryflagsOptions);

    execute(callback: (error: any, data: countryflagsResponse | null) => void): Promise<countryflagsResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: countryflagsResponse | null) => void): Promise<countryflagsResponse>;
    execute(query?: Record<string, any>): Promise<countryflagsResponse>;
  }
}
