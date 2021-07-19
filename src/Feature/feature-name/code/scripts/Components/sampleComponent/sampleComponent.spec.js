import Vue from 'vue';
import sampleComponent from './sampleComponent.vue'

import { mount } from 'vue-test-utils'
import { createRenderer } from 'vue-server-renderer'

const errorMessage = 'Online';

const renderer = createRenderer()

const eventBus = (function () {
  return {
    $on() { return true },
    $emit() { return true }
  }
}())

Object.defineProperty(window, 'eventBus', { value: eventBus })

const wrapper = mount(sampleComponent, {
  propsData: {
    errorMessage
  }
})

describe('Simple mode Props', () => {
  it('Simple mode Props', () => {
    expect(typeof wrapper.vm.errorMessage).toBe('string');
  });
  it('Simple mode props validation', () => {
    expect(wrapper.vm.errorMessage).toBe(errorMessage);
  });
  it('Simple mode props function verification', () => {
    expect(typeof sampleComponent.props).toBe('object');
  });
})