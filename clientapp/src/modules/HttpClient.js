import config from "@/modules/config";
import axios from "axios";

export default {
    async Get(url = "", after = () => { }) {
        console.log("in get")
        let fullUrl = config.api_endpoint + url
        let response = await fetch(fullUrl, {
            method: "GET",
            cache: 'no-cache',
        },
        ).then(response => {
            after(response)
            return response.json();
        })
    },
    async Post(url = "", data = {}, after = () => { }) {
        console.log("in post")
        let fullUrl = config.api_endpoint + url
        let apiResponse = await fetch(fullUrl, {
            method: "POST",
            cache: 'no-cache',
            headers: new Headers({ 'content-type': 'application/json' }),
            body: JSON.stringify(data)
        });
        let response = await apiResponse.json();

        if (response.status >= 500) {

        }
        else if (response.status >= 400) {

        }
        else if (response.status >= 300) {

        } else {
            after(response)
        }
        return response

    },

}