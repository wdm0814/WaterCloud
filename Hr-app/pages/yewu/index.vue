<template>
	<view class="container container333545">
		<view class="flex flex-wrap diygw-col-24 flex-direction-column flex6-clz">
			<view class="flex diygw-col-24 justify-around flex-nowrap white flex2-clz" @tap="navigateTo" data-type="page" data-url="/pages/null">
				<view class="flex flex-wrap diygw-col-12 flex-direction-column items-center flex1-clz" @tap="navigateTo" data-type="page" data-url="/pages/null">
					<text class="diygw-col-0 diygw-text-lg text-blue"> 10 </text>
					<text class="diygw-col-0 text-grey"> 员工总数 </text>
				</view>
				<view class="flex flex-wrap diygw-col-12 flex-direction-column items-center flex4-clz">
					<text class="diygw-col-0 diygw-text-lg text-blue"> 2 </text>
					<text class="diygw-col-0 text-grey"> 新闻公告 </text>
				</view>
			</view>
			<view class="flex diygw-col-24 white list-clz">
				<view class="diygw-list">
					<view style="" class="diygw-item col-50 row solid-bottom list-item-clz">
						<view class="diygw-avatar list-icon-clz">
							<image mode="aspectFit" class="diygw-avatar-img" src="/static/icon2_ds.png"></image>
							<view class="diygw-tag badge empty list-badge-0 red"></view>
						</view>
						<view class="content">
							<view class="title"> 新闻公告 </view>
							<view style="color: #a4a4a4" class="text-sm remark"> NEWS&NOTICE </view>
						</view>
					</view>
				</view>
			</view>
			<view class="flex flex-wrap diygw-col-24 flex-direction-column white flex5-clz">
				<view class="diygw-title flex diygw-col-24">
					<view class="title font-normal"> 常用办公 </view>
					<view class="more">
						<text class="diy-icon-right"></text>
					</view>
				</view>
				<view class="flex diygw-col-24">
					<view class="diygw-grid col-4">
						<view class="diygw-grid-item">
							<view class="diygw-grid-inner grid-item-clz">
								<view class="diygw-grid-icon diygw-avatar grid-icon-clz">
									<image mode="aspectFit" class="diygw-avatar-img" src="/static/db.png"></image>
								</view>
								<view class="diygw-grid-title"> 员工入职 </view>
							</view>
						</view>
						<view class="diygw-grid-item">
							<view class="diygw-grid-inner grid-item-clz">
								<view class="diygw-grid-icon diygw-avatar grid-icon-clz">
									<image mode="aspectFit" class="diygw-avatar-img" src="/static/jbqx.png"></image>
								</view>
								<view class="diygw-grid-title"> 员工离职 </view>
							</view>
						</view>
						<view class="diygw-grid-item">
							<view class="diygw-grid-inner grid-item-clz">
								<view class="diygw-grid-icon diygw-avatar grid-icon-clz">
									<image mode="aspectFit" class="diygw-avatar-img" src="/static/bd2.png"></image>
								</view>
								<view class="diygw-grid-title"> 员工列表 </view>
							</view>
						</view>
					</view>
				</view>
			</view>
		</view>
		<view class="clearfix"></view>
	</view>
</template>

<script>
	export default {
		data() {
			return {
				//用户全局信息
				userInfo: {},
				//页面传参
				globalOption: {},
				//自定义全局变量
				globalData: {}
			};
		},
		onShow() {
			this.setCurrentPage(this);
		},
		onLoad(option) {
			this.setCurrentPage(this);
			if (option) {
				this.setData({
					globalOption: this.getOption(option)
				});
			}

			this.init();
		},
		methods: {
			async init() {}
		}
	};
</script>

<style lang="scss" scoped>
	.flex6-clz {
		z-index: 100;
		background-repeat: no-repeat;
		background-size: contain;
		background-image: url(/static/oa.png);
	}
	.flex2-clz {
		padding-top: 40rpx;
		border-bottom-left-radius: 20rpx;
		z-index: 100;
		padding-left: 20rpx;
		padding-bottom: 40rpx;
		border-top-right-radius: 20rpx;
		margin-right: 20rpx;
		background-color: rgba(217, 217, 217, 0.13);
		margin-left: 20rpx;
		box-shadow: 0rpx 4rpx 8rpx 3px rgba(181, 207, 255, 0.5);
		overflow: hidden;
		width: calc(100% - 20rpx - 20rpx) !important;
		border-top-left-radius: 20rpx;
		margin-top: 240rpx;
		border-bottom-right-radius: 20rpx;
		margin-bottom: 20rpx;
		padding-right: 20rpx;
	}
	.flex1-clz {
		z-index: 100;
		border-right: 2rpx solid #eee;
	}
	.flex4-clz {
		z-index: 100;
		border-right: 2rpx solid #eee;
	}
	.list-clz {
		background-color: rgba(217, 217, 217, 0.13);
		margin-left: 20rpx;
		border-bottom-left-radius: 20rpx;
		box-shadow: 0rpx 4rpx 8rpx 3px rgba(181, 207, 255, 0.5);
		overflow: hidden;
		width: calc(100% - 20rpx - 20rpx) !important;
		border-top-left-radius: 20rpx;
		margin-top: 20rpx;
		border-top-right-radius: 20rpx;
		border-bottom-right-radius: 20rpx;
		margin-bottom: 20rpx;
		margin-right: 20rpx;
	}
	.list-item-clz {
		margin: 0px;
		padding: 10px;
	}
	.list-item-clz .list-icon-clz {
		width: 40px;
		height: 40px;
		font-size: calc(40px - 4px) !important;
	}

	.list-badge-0 {
		padding-left: 0px;
		padding-right: 0px;
		right: 2px;
		top: 0px;
	}
	.flex5-clz {
		border-bottom-left-radius: 20rpx;
		z-index: 100;
		border-top-right-radius: 20rpx;
		margin-right: 20rpx;
		background-color: rgba(217, 217, 217, 0.13);
		margin-left: 20rpx;
		box-shadow: 0rpx 4rpx 8rpx 3px rgba(181, 207, 255, 0.5);
		overflow: hidden;
		width: calc(100% - 20rpx - 20rpx) !important;
		border-top-left-radius: 20rpx;
		margin-top: 20rpx;
		border-bottom-right-radius: 20rpx;
		margin-bottom: 20rpx;
	}
	.grid-item-clz {
		margin: 0px;
		padding: 10px;
	}
	.grid-icon-clz {
		font-size: calc(30px - 4px) !important;

		width: 30px;
		height: 30px;
	}
	.container333545 {
	}
</style>
