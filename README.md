# Side-Project-Try-Swagger-RESTfulAPI

![alt](/TryIt.gif)

## 目的

幫老弟寫 API ，好練習串 API 接口與 ajax SSR，順便嘗試 RESTfulAPI 的 Lv 1 - 3，與 Swagger 套件。

## 題目

1. 一句話簡單解釋下列名詞。
   
   * 名詞
     * `域名系統` DNS / `網路位址(RealName)` IP / `域名(NickName)` DomainName / `通訊埠` Port [> 可參考](https://medium.com/@miahsuwork/%E7%AC%AC%E5%85%AD%E9%80%B1-%E7%B6%B2%E8%B7%AF%E5%9F%BA%E7%A4%8E-http-request-response-7d7e0cb88ed8)
     * `網路架構` (七層 OSI 模型)、(五層 TCP/IP 模型) [> 可參考](http://eportfolio.lib.ksu.edu.tw/~4970Q063/blog?node=000100005)
     * `網路協議` (Http/Https) (Socket) (HLS/RTMP) [> 可參考](https://twgame.wordpress.com/2015/02/03/tcpiphttpsocketudp/)
     * `封包` Data packet / `請求` Request / `回應` Response [> 可參考](https://yakimhsu.com/project/project_w4_Network_http.html)
     * `封包傳遞方式` get / post ( put / delete ) [> 可參考](https://www.google.com/search?sxsrf=ALeKk03llIX8j1ENlzd1w_55yKW6CQm-dA%3A1599410797452&ei=bRJVX9SbG863mAX6oaTwBA&q=get+post&oq=get+PO&gs_lcp=CgZwc3ktYWIQAxgAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADoFCAAQsQM6BAgAEEM6CAgAELEDEIMBUJF7WLGGAWC4jwFoAHAAeACAAUCIAfkBkgEBNZgBAKABAqABAaoBB2d3cy13aXrAAQE&sclient=psy-ab)
     
     * `靜態網頁` / `動態網頁`
     
     * `網頁生命週期` ( JS生命週期 ) [> 可參考](https://codertw.com/%E5%89%8D%E7%AB%AF%E9%96%8B%E7%99%BC/24350/)
     * `應用程式介面(接口)` API ( Application Programming Interface )
     * `網頁技術-資料索取方式` AJAX ( Asynchronous JavaScript and XML )
     * `網頁技術-資料組成` SPA ( 單頁面應用程式 Single Page Application ) / MPA ( 多頁面應用程式 Multi-page Application ) / PWA ( 漸進式應用程式 Progressive Web Application)
     * `網頁技術-頁面產生方式` ( `靜態網站生成器` Static Site Generators / `客戶端渲染` Client Side Render / `伺服器端渲染` Server Side Render )[> 可參考](https://www.jianshu.com/p/f8b4f3776d9f)
     * `後端應用` ( Framework `程式框架` / Framework Language `程式語言` / `直、編譯` / `框架、語言生命週期` [> 可參考](https://adon988.logdown.com/posts/7597721-asp-dot-net-life-cycle) )
     * `後端應用` ( Database `資料庫` / Database Management System `資料庫管理系統` / SQL `資料庫管理系統語言` )
     
     * `集中式系統` / `分散式系統` [> 可參考](https://rickhw.github.io/2018/06/18/Architecture/Gossip-in-Distributed-Systems/#%E4%B8%89%E3%80%81%E7%95%B6%E4%BB%A3%E5%B7%A5%E7%A8%8B%E6%96%B9%E6%B3%95%E8%88%87%E5%AF%A6%E8%B8%90)


     <P> </P>
     <details>
       <summary>延伸文章</summary>
     
     * [三種渲染畫面方式](https://juejin.im/post/6855917901090652174)

     </details>

2. 一句話簡單回答下列題目。
   * 題目
     1. 解釋 `動態` 與 `靜態網頁` 差別 ?
        <details>
          <summary>參考答案</summary>
          <p> 靜態網頁副檔案名稱為 .html，動態網頁則依據不同的框架、不同的程式語言而有多種副檔名，唯一不變的是，通常除了快取用途而載入客戶端(本地/本機)的檔案，不管是靜或動態檔案都會放置於伺服器端(後端/雲端)再藉由請求提供響應至客戶端。 </p> 
        </details>
     2. 解釋 `程式框架` 、 `編譯/直譯` 、 `程式生命週期` 三者之間的關係 ?
        <details>
         <summary>參考答案</summary>
         <p> 不同 `程式框架` 擁有不同的 `程式生命週期` ，但根據語言特性分為編譯與直譯，但不管是編譯或是直譯都是一行一行的讀取，讀完再換頁讀取，只要不是 .html 為副檔名都需要經過編譯成 html 檔案，瀏覽器才讀得懂。 </p> 
        </details>
     3. 以郵差寄信形容較簡單的 `集中式系統` 與 `OSI 七層` 或 `ICP/IP 五層` 之間的關係 ?  [> 可參考](http://eportfolio.lib.ksu.edu.tw/~4970Q063/blog?node=000100005)  
        <details>
         <summary>參考答案</summary>
         <p> 。 </p> 
        </details>
     4. `AJAX` 與 `CSR 前端渲染`、`SPA 單頁應用程式` 之間的關係 ? [> 可參考](https://blog.csdn.net/style_zyh/article/details/74216593)
     <p> </p>
     <details>
       <summary>可參考</summary>
   
     * 待補
     
     </details>
   
3. 將上述名詞補進關係圖內。
   * 可參考
4. 依照前三學習到的基礎常識，並依照下列步驟，串接API並推版至 DBUG 專案。
   * 步驟教學 :
     * 1. 首先將此專案 clone 至本地 (目的是部屬 API框架後端程式)

> 以下為API框架後端程式 實作，不用看

---

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

## API 實作步驟

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
