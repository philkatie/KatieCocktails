# Katie Cocktails API

- [Katie Cocktails API](#katie-cocktails-api)
  - [Create Cocktail](#create-cocktail)
    - [Create Cocktail Request](#create-cocktail-request)
    - [Create Cocktail Response](#create-cocktail-response)
  - [Get Cocktail](#get-cocktail)
    - [Get Cocktail Request](#get-cocktail-request)
    - [Get Cocktail Response](#get-cocktail-response)
  - [Update Cocktail](#update-cocktail)
    - [Update Cocktail Request](#update-cocktail-request)
    - [Update Cocktail Response](#update-cocktail-response)
  - [Delete Cocktail](#delete-cocktail)
    - [Delete Cocktail Request](#delete-cocktail-request)
    - [Delete Cocktail Response](#delete-cocktail-response)

## Create Cocktail

### Create Cocktail Request

```js
POST /cocktails
```

```json
{
    "name": "Cranberry Margarita",
    "description": "Perfect for a wintery party!",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "ingredients": [
        "Cranberry Juice",
        "Fresh Lime Juice"
    ],
    "alcohol": [
        "Tequila",
        "Cointreau"
    ]
}
```

### Create Cocktail Response

```js
201 Created
```

```yml
Location: {{host}}/Cocktails/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Cranberry Margarita",
    "description": "Perfect for a wintery party!",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "ingredients": [
        "Cranberry Juice",
        "Fresh Lime Juice"
    ],
    "alcohol": [
        "Tequila",
        "Cointreau"
    ]
}
```

## Get Cocktail

### Get Cocktail Request

```js
GET /cocktails/{{id}}
```

### Get Cocktail Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Cranberry Margarita",
    "description": "Perfect for a wintery party!",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "ingredients": [
        "Cranberry Juice",
        "Fresh Lime Juice"
    ],
    "alcohol": [
        "Tequila",
        "Cointreau"
    ]
}
```

## Update Cocktail

### Update Cocktail Request

```js
PUT /cocktails/{{id}}
```

```json
{
    "name": "Cranberry Margarita",
    "description": "Perfect for a wintery party!",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "ingredients": [
        "Cranberry Juice",
        "Fresh Lime Juice"
    ],
    "alcohol": [
        "Tequila",
        "Cointreau"
    ]
}
```

### Update Cocktail Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Cocktails/{{id}}
```

## Delete Cocktail

### Delete Cocktail Request

```js
DELETE /cocktails/{{id}}
```

### Delete Cocktail Response

```js
204 No Content
```