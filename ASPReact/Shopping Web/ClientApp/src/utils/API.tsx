import axios from 'axios';

export default {
    getProductList: function () {
        return axios.get("/api/products")
    },

    getUserInfo: function () {
        return axios.get("api/userID")
    },

    getUserCartInfo: function (userID: number) {
        return axios.get("api/users/" + userID + "/cart")
    },

    getUserOrderHistory: function (userID: number) {
        return axios.get("api/users" + userID + "/history")
    },

    postUpdateCartInfo: function (userID: number, newproduct: any) {
        return axios.post("api/users" + userID + "/cart", newproduct)
    },

    postUpdateUserOrderHistory: function (userID: number, newhistory: any) {
        return axios.post("api/users" + userID + "/history", newhistory)
    },

    postRegisterNewUser: function (userInfo: any) {
        return axios.post("api/users", userInfo)
    },

    postUserLogin: function (userID: number) {
        return axios.post("api/users/login", userID)
    },

    getUserLogOut: function () {
        return axios.get("api/users/logout").then(res => {return res})
    }
}