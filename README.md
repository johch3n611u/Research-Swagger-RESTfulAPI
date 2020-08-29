# Side-Project-Try-Swagger-RESTfulAPI

## 目的

幫老弟寫 API ，好練習串 API 接口與 ajax SSR，順便嘗試 RESTfulAPI 的 Lv 1 - 3，與 Swagger 套件。

## 網路基礎

<https://medium.com/@miahsuwork/%E7%AC%AC%E5%85%AD%E9%80%B1-%E7%B6%B2%E8%B7%AF%E5%9F%BA%E7%A4%8E-http-request-response-7d7e0cb88ed8>

<https://yakimhsu.com/project/project_w4_Network_http.html>

## 前端工具( 物件, 模組 )

* 此次會要求老弟嘗試三種方法
  * XMLHttpRequest 原生 API
  * jQuery.ajax() 第三方庫
  * fetch 原生 API

<https://developer.mozilla.org/zh-TW/docs/Web/API/Fetch_API/Using_Fetch>

<https://wcc723.github.io/javascript/2017/12/28/javascript-fetch/>

<https://developer.mozilla.org/zh-TW/docs/Web/API>

<https://www.itread01.com/content/1564589404.html>

## [RESTfulAPI 簡介 by https://openhome.cc](https://openhome.cc/Gossip/Spring/HATEOAS.html)

* Level 0 -  使用 HTTP 做為資料傳輸的媒介。

* Level 1 - 不要提供一個包山包海的 API，而是要區分資源，每個資源都該有對應的 API。

使用多個 URI 與一個 HTTP 方法，URI 代表了資源，像是 /show_message、/create_message、/update_message、/delete_message 都是資源，HTTP 方法只是用來發起請求，至於請求的細節由請求本體來提供，例如，在請求 /show_message 這項資源時，若包含 all 請求參數，表示顯示全部的訊息，若是 "id=1" 這類請求參數，表示顯示指定的訊息。

* Level 2 - 透過 HTTP Method 區分新增(Create)、查詢(Read)、修改(Update)跟刪除(Delete)。

使用多個 URI、多個 HTTP 方法，並善用 HTTP 回應狀態碼，URI 用來代表資源，像是 /messages、/messages/1，HTTP 方法用來表示想進行的操作，例如 GET /messages 表示取得全部訊息，GET /messages/1 表示取得指定訊息，POST /messages 表示新增訊息、DELETE /messages/1 表示刪除指定訊息等，〈簡介 RestTemplate〉的簡單應用程式就是此類。

* Level 3 - 對同資源可以用鏈結表達的方式，向下延伸查詢或修改。

更進一步地，支援 HATEOAS（Hypermedia As The Engine Of Application State）的概念，就類似 HTML 頁面鏈結，你可以從這個頁面得知可通往哪些頁面，在 REST 的 Level 3 模型中，客戶端可以從某個資源，知道還有哪些其他相關的資源，以及如何對它進行操作，〈@RepositoryRestResource〉的範例專案，就是這一類。

## 步驟

1. 跟著步驟做 DTO 與 API
2. 網址為 <https://localhost:44317/swagger/index.html>
3. [研究動態泛型 反應式程式設計](https://mileslin.github.io/2016/12/%E5%8B%95%E6%85%8B%E6%8C%87%E5%AE%9A%E6%B3%9B%E5%9E%8B%E5%9E%8B%E5%88%A5/)
4. 最後動態泛型的反傳值沒研究成功，有時間再研究...

## 參考

<https://blog.johnwu.cc/article/ironman-day13-asp-net-core-web-api-document-generator-swagger.html>

<https://openhome.cc/Gossip/Spring/HATEOAS.html>

<https://blog.johnwu.cc/article/ironman-day12-asp-net-core-restful-api.html>

<https://xd.adobe.com/view/dc5ebe5c-3e56-4981-a010-158b5ded0e72-890d/grid>

<https://dotblogs.com.tw/AceLee/2019/11/05/125029>

<https://li-jin-xing-vulcan.gitbook.io/csharp/genericdynobject>

<https://mileslin.github.io/2016/12/%E5%8B%95%E6%85%8B%E6%8C%87%E5%AE%9A%E6%B3%9B%E5%9E%8B%E5%9E%8B%E5%88%A5/>
