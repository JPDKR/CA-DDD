# Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
  "id": "0",
  "name": "Yummy Menu",
  "description": "A menu with yummy food",
  "averageRating": 4.5,
  "section":[
    {
        "id":"0",
        "name":"Appetizers",
        "description":"Starters",
        "items":[
            {
                "id": "0",
                "name": "Fried Pickles",
                "description": "Deep fried pickles",
                "price": 5.99
            }
        ]
    }
  ],
  "createdDateTime": "",
  "updateDateTime":"",
  "hostId": "0",
  "dinnersIds": ["0"],
  "menuReviewsId": ["0"]
}
```
