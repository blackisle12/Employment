Employment Exercise based on questionnaire.

Sample test data

POST
{
  "firstName": "test",
  "lastName": "gelo",
  "email": "user@example.com",
  "address": {
    "street": "pampanga",
    "city": "angeles",
    "postCode": 2009
  },
  "employments": [
    {
      "company": "Company A",
      "monthsOfExperience": 5,
      "salary": 0,
      "startDate": "2023-08-13T14:45:37.940Z",
      "endDate": null
    },
	{
      "company": "Company B",
      "monthsOfExperience": 2,
      "salary": 0,
      "startDate": "2023-08-13T14:45:37.940Z",
      "endDate": "2024-08-13T14:45:37.940Z"
    }
  ]
}

PUT
{
  "id": 1,
  "firstName": "test",
  "lastName": "gelo",
  "email": "user@example.com",
  "address": {
    "street": "pampanga",
    "city": "san fernando",
    "postCode": 2003
  },
  "employments": [
    {
	  "id": 1,
      "company": "Company A - edited",
      "monthsOfExperience": 5,
      "salary": 0,
      "startDate": "2023-08-13T14:45:37.940Z",
      "endDate": null
    },
	{
	  "id": 2,
      "company": "Company B",
      "monthsOfExperience": 2,
      "salary": 0,
      "startDate": "2023-08-13T14:45:37.940Z",
      "endDate": "2024-08-13T14:45:37.940Z",
	  "isDeleted": true
    }
  ]
}
